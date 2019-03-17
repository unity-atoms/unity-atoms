using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector2/List", fileName = "Vector2List", order = CreateAssetMenuUtils.Order.LIST)]
    public class Vector2List : ScriptableObjectList<Vector2, Vector2Event> { }
}