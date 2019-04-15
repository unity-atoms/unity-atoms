using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/Variable", fileName = "IntVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public sealed class IntVariable : EquatableScriptableObjectVariable<int, IntEvent, IntIntEvent>
    {
    }
}
