using UnityEngine;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/Int Setter")]
    public sealed class IntSetter : MonoBehaviour
    {
        [SerializeField]
        private IntVariable _variable;

        public void Set(int amount)
        {
            _variable.Value = amount;
        }

        public void Add(int amount)
        {
            _variable.Value += amount;
        }

        public void Subtract(int amount)
        {
            _variable.Value -= amount;
        }
    }
}
