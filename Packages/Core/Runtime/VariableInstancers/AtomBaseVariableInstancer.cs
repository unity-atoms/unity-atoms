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
    public abstract class AtomBaseVariableInstancer<T, V> : MonoBehaviour, IVariable<V>
        where V : AtomBaseVariable<T>
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
        /// Override to add implementation specific setup on `OnEnable`.
        /// </summary>
        protected virtual void ImplSpecificSetup() { }

        private void OnEnable()
        {
            Assert.IsNotNull(Base);
            _inMemoryCopy = Instantiate(Base);
            ImplSpecificSetup();
        }
    }
}
