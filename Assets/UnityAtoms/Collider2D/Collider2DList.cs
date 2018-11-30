using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Collider2D/List", fileName = "Collider2DList", order = CreateAssetMenuUtils.Order.LIST)]
    public class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent> { }
}