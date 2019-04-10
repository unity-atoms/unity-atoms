using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/List", fileName = "IntList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class IntList : ScriptableObjectList<int, IntEvent> { }
}
