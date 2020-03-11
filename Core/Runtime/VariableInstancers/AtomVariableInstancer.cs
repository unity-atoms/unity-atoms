using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms
{
    /// <summary>
    /// A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable.
    /// This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to
    /// react accordingly when a prefab with an associated atom is added or deleted to the scene.
    /// </summary>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="P">IPair of type `T`.</typeparam>
    /// <typeparam name="T">The value type.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T</typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomVariableInstancer<V, P, T, E1, E2, F, CO, L> : MonoBehaviour, IGetEvent, ISetEvent
        where V : AtomVariable<T, P, E1, E2, F>
        where P : struct, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where CO : IGetValue<IAtomCollection>
        where L : IGetValue<IAtomList>
    {
        /// <summary>
        /// Getter for retrieving the in memory runtime variable.
        /// </summary>
        public V Variable { get => _inMemoryCopy; }

        /// <summary>
        /// Getter for retrieving the value of the in memory runtime variable.
        /// </summary>
        public T Value { get => _inMemoryCopy.Value; set => _inMemoryCopy.Value = value; }

        public virtual V Base { get => _base; }

        [SerializeField]
        [ReadOnly]
        protected V _inMemoryCopy = default(V);

        /// <summary>
        /// The variable that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        protected V _base = null;

        /// <summary>
        /// If assigned the in memory copy variable will be added to the collection on Start using the gameObject's instance id as key. The value will also be removed from the collection OnDestroy.
        /// </summary>
        [SerializeField]
        private CO _syncToCollection = default(CO);

        /// <summary>
        /// If assigned the in memory copy variable will be added to the list on Start. The value will also be removed from the list OnDestroy.
        /// </summary>
        [SerializeField]
        private L _syncToList = default(L);

        /// <summary>
        /// Override to add implementation specific setup on `OnEnable`.
        /// </summary>
        protected virtual void ImplSpecificSetup() { }

        private void OnEnable()
        {
            Assert.IsNotNull(Base);
            _inMemoryCopy = Instantiate(Base);

            if (Base.Changed != null)
            {
                _inMemoryCopy.Changed = Instantiate(Base.Changed);
            }

            if (Base.ChangedWithHistory != null)
            {
                _inMemoryCopy.ChangedWithHistory = Instantiate(Base.ChangedWithHistory);
            }

            ImplSpecificSetup();
        }

        void Start()
        {
            // Adding to the collection on Start instead of OnEnable because of timing issues that otherwise occurs when listeners register themselves OnEnable. 
            // This is an issue when a Game Object has a Variable Instancer attached to it when the scene starts and at the same time their is an AtomBaseListener listening to the associated Added event to a Collection. 
            if (_syncToCollection != null)
            {
                _syncToCollection.GetValue().Add(GetInstanceID().ToString(), _inMemoryCopy);
            }

            if (_syncToList != null)
            {
                _syncToList.GetValue().Add(_inMemoryCopy);
            }
        }

        private void OnDestroy()
        {
            if (_syncToCollection != null)
            {
                _syncToCollection.GetValue().Remove(GetInstanceID().ToString());
            }

            if (_syncToList != null)
            {
                _syncToList.GetValue().Remove(_inMemoryCopy);
            }
        }

        /// <summary>
        /// Get event by type. 
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>The event.</returns>
        public E GetEvent<E>() where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
                return (_inMemoryCopy.Changed as E);
            if (typeof(E) == typeof(E2))
                return (_inMemoryCopy.ChangedWithHistory as E);

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }

        /// <summary>
        /// Set event by type. 
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
            {
                _inMemoryCopy.Changed = (e as E1);
                return;
            }
            if (typeof(E) == typeof(E2))
            {
                _inMemoryCopy.ChangedWithHistory = (e as E2);
                return;
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }
    }
}
