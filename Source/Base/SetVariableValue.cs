using UnityEngine;

namespace UnityAtoms
{
    public abstract class SetVariableValue<T, V, R, E1, E2> : VoidAction where E1 : GameEvent<T> where E2 : GameEvent<T, T> where V : ScriptableObjectVariable<T, E1, E2> where R : ScriptableObjectReference<T, V, E1, E2>
    {
        [SerializeField]
        private V Variable = null;

        [SerializeField]
        private R Value = null;

        public override void Do()
        {
            Variable.Value = Value.Value;
        }
    }
}
