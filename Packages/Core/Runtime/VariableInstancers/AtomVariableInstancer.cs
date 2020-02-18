using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-hotpink")]
    public abstract class AtomVariableInstancer<V, T, E1, E2, F> : MonoBehaviour
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
    {
        /// <summary>
        /// Getter for retrieving the runtime variable.
        /// </summary>
        public V Variable { get => _inMemoryCopy; }

        /// <summary>
        /// Getter for retrieving the value of the runtime variable.
        /// </summary>
        public T Value { get => _inMemoryCopy.Value; set => _inMemoryCopy.Value = value; }

        private V _inMemoryCopy;

        /// <summary>
        /// The variable that the in memory copy will be based on when created at runtime.
        /// </summary>
        [SerializeField]
        private V _variableBase = null;

        private void OnEnable()
        {
            Assert.IsNotNull(_variableBase);
            _inMemoryCopy = Instantiate(_variableBase);

            if (_variableBase.Changed != null)
            {
                _inMemoryCopy.Changed = Instantiate(_variableBase.Changed);
            }

            if (_variableBase.ChangedWithHistory != null)
            {
                _inMemoryCopy.ChangedWithHistory = Instantiate(_variableBase.ChangedWithHistory);
            }
        }
    }
}
