using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Variable", fileName = "BoolVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public sealed class BoolVariable : EquatableScriptableObjectVariable<bool, BoolEvent, BoolBoolEvent> { }
}
