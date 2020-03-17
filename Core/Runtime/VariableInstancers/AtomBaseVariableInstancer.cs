using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms
{
    /// <summary>
    /// A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable.
    /// This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to
    /// react accordingly when a prefab with an assoicated atom is added or deleted to the scene.
    /// </summary>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="P">IPair of type `T`.</typeparam>
    /// <typeparam name="T">The value type.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T</typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomBaseVariableInstancer<T, V, CO, L> : MonoBehaviour
        where V : AtomBaseVariable<T>
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
        /// If this string is not null or white space and if a Collection to sync to is defined, this is the key that will used when adding the Variable to the Collection. If not defined the key defaults to this GameObject's instance id.
        /// </summary>
        [SerializeField]
        private String _syncToCollectionKey = default;

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
            ImplSpecificSetup();
        }

        void Start()
        {
            // Adding to the collection on Start instead of OnEnable because of timing issues that otherwise occurs when listeners register themselves OnEnable. 
            // This is an issue when a Game Object has a Variable Instancer attached to it when the scene starts and at the same time their is an AtomBaseListener listening to the associated Added event to a Collection. 
            if (_syncToCollection != null && _syncToCollection.GetValue() != null)
            {
                _syncToCollection.GetValue().Add(String.IsNullOrWhiteSpace(_syncToCollectionKey) ? GetInstanceID().ToString() : _syncToCollectionKey, _inMemoryCopy);
            }

            if (_syncToList != null && _syncToList.GetValue() != null)
            {
                _syncToList.GetValue().Add(_inMemoryCopy);
            }
        }

        private void OnDestroy()
        {
            if (_syncToCollection != null && _syncToCollection.GetValue() != null)
            {
                _syncToCollection.GetValue().Remove(GetInstanceID().ToString());
            }

            if (_syncToList != null && _syncToList.GetValue() != null)
            {
                _syncToList.GetValue().Remove(_inMemoryCopy);
            }
        }
    }
}
