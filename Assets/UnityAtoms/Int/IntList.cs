using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/List", fileName = "IntList", order = CreateAssetMenuUtils.Order.LIST)]
    public class IntList : ScriptableObjectList<int, IntEvent> { }
}