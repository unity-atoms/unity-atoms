using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms
{

    /// <summary>
    /// An Event Instancer is a MonoBehaviour that takes an Event as a base and creates an in memory copy of it OnEnable.
    /// This is handy when you want to use Events for prefabs that are instantiated at runtime. 
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    /// <typeparam name="E">Event of type T.</typeparam>
    [EditorIcon("atom-icon-sign-blue")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomEventInstancer<T, E> : MonoBehaviour
        where E : AtomEvent<T>
    {
        /// <summary>
        /// Getter for retrieving the in memory runtime Event.
        /// </summary>
        public E Event { get => _inMemoryCopy; }

        [SerializeField]
        [ReadOnly]
        private E _inMemoryCopy;

        /// <summary>
        /// The Event that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        private E _base = null;

        private void OnEnable()
        {
            Assert.IsNotNull(_base);
            _inMemoryCopy = Instantiate(_base);
        }
    }
}
