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
    /// <typeparam name="T">The value type.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T</typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomVariableInstancer<V, T, E1, E2, F> : MonoBehaviour
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
    {
        /// <summary>
        /// Getter for retrieving the in memory runtime variable.
        /// </summary>
        public V Variable { get => _inMemoryCopy; }

        /// <summary>
        /// Getter for retrieving the value of the in memory runtime variable.
        /// </summary>
        public T Value { get => _inMemoryCopy.Value; set => _inMemoryCopy.Value = value; }

        private V _inMemoryCopy;

        /// <summary>
        /// The variable that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        private V _base = null;

        /// <summary>
        /// If assigned the in memory copy variable will be added to the collection on Start using the gameObject's instance id as key. The value will also be removed from the collection OnDestroy.
        /// </summary>
        [SerializeField]
        private AtomCollection _syncToCollection = null;

        /// <summary>
        /// If assigned the in memory copy variable will be added to the list on Start. The value will also be removed from the list OnDestroy.
        /// </summary>
        [SerializeField]
        private AtomList _syncToList = null;

        private void OnEnable()
        {
            Assert.IsNotNull(_base);
            _inMemoryCopy = Instantiate(_base);

            if (_base.Changed != null)
            {
                _inMemoryCopy.Changed = Instantiate(_base.Changed);
            }

            if (_base.ChangedWithHistory != null)
            {
                _inMemoryCopy.ChangedWithHistory = Instantiate(_base.ChangedWithHistory);
            }
        }

        void Start()
        {
            // Adding to the collection on Start instead of OnEnable because of timing issues that otherwise occurs when listeners register themselves OnEnable. 
            // This is an issue when a Game Object has a Variable Instancer attached to it when the scene starts and at the same time their is an AtomBaseListener listening to the associated Added event to a Collection. 
            if (_syncToCollection != null)
            {
                _syncToCollection.Value.Add(GetInstanceID().ToString(), _inMemoryCopy);
            }

            if (_syncToList != null)
            {
                _syncToList.Value.Add(_inMemoryCopy);
            }
        }

        private void OnDestroy()
        {
            if (_syncToCollection != null)
            {
                _syncToCollection.Value.Remove(GetInstanceID().ToString());
            }

            if (_syncToList != null)
            {
                _syncToList.Value.Remove(_inMemoryCopy);
            }
        }
    }
}
