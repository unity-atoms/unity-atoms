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
    /// <typeparam name="T">The value type.</typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomVariableInstancer<T> : MonoBehaviour, IGetEvent, ISetEvent
    {
        /// <summary>
        /// Getter for retrieving the in memory runtime variable.
        /// </summary>
        public AtomBaseVariable<T> Variable { get => _inMemoryCopy; }

        /// <summary>
        /// Getter for retrieving the value of the in memory runtime variable.
        /// </summary>
        public T Value { get => _inMemoryCopy.Value; set => _inMemoryCopy.Value = value; }

        public virtual AtomBaseVariable<T> Base { get => _base; }

        [SerializeField]
        [ReadOnly]
        protected AtomBaseVariable<T> _inMemoryCopy = default(AtomBaseVariable<T>);

        /// <summary>
        /// The variable that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        protected AtomBaseVariable<T> _base = null;

        private void OnEnable()
        {
            Assert.IsNotNull(Base);
            _inMemoryCopy = Instantiate(Base);
            ImplSpecificSetup();
        }

        /// <summary>
        /// Override to add implementation specific setup on `OnEnable`.
        /// </summary>
        protected virtual void ImplSpecificSetup()
        {
            if (_inMemoryCopy is AtomVariable<T> inMemoryCopy && Base is AtomVariable<T> baseVariable)
            {
                if (baseVariable.Changed != null)
                {
                    inMemoryCopy.Changed = Instantiate(baseVariable.Changed);
                }

                if (baseVariable.ChangedWithHistory != null)
                {
                    inMemoryCopy.ChangedWithHistory = Instantiate(baseVariable.ChangedWithHistory);
                }
            }
        }

        /// <summary>
        /// Get event by type. 
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>The event.</returns>
        public E GetEvent<E>() where E : AtomEventBase
        {
            if (_inMemoryCopy is AtomVariable<T> inMemoryCopy)
            {
                if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<T>)))
                {
                    return (inMemoryCopy.Changed as E);
                }
                if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<Pair<T>>)))
                {
                    return (inMemoryCopy.ChangedWithHistory as E);
                }
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(AtomEvent<T>)} or {typeof(AtomEvent<Pair<T>>)}.");
        }

        /// <summary>
        /// Set event by type. 
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            if (_inMemoryCopy is AtomVariable<T> inMemoryCopy)
            {
                if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<T>)))
                {
                    inMemoryCopy.Changed = (e as AtomEvent<T>);
                    return;
                }
                if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<Pair<T>>)))
                {
                    inMemoryCopy.ChangedWithHistory = (e as AtomEvent<Pair<T>>);
                    return;
                }
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(AtomEvent<T>)} or {typeof(AtomEvent<Pair<T>>)}.");
        }
    }
}
