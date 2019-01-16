using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Bool", fileName = "BoolVariable", order = 2)]
    public class BoolVariable : EquatableScriptableObjectVariable<bool, BoolEvent, BoolBoolEvent>
    {
        public static implicit operator bool(BoolVariable variable)
        {
            return variable.Value;
        }
    }
}