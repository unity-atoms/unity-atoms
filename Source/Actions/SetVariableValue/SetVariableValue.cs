using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class SetVariableValue<T, V, R, E1, E2> : VoidAction
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where V : AtomVariable<T, E1, E2>
        where R : AtomReference<T, V>
    {
        [FormerlySerializedAs("Variable")]
        [SerializeField]
        private V _variable = null;

        [FormerlySerializedAs("Value")]
        [SerializeField]
        private R _value = null;

        public override void Do()
        {
            _variable.Value = _value.Value;
        }
    }
}
