using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/String/List", fileName = "StringList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class StringList : ScriptableObjectList<string, StringEvent> { }
}
