using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/List", fileName = "FloatList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class FloatList : ScriptableObjectList<float, FloatEvent> { }
}
