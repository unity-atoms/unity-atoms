using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Bool/List", fileName = "BoolList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class BoolList : ScriptableObjectList<bool, BoolEvent> { }
}
