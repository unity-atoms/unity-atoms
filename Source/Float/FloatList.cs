using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/List", fileName = "FloatList", order = CreateAssetMenuUtils.Order.LIST)]
    public class FloatList : ScriptableObjectList<float, FloatEvent> { }
}