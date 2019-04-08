using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Collider2D/List", fileName = "Collider2DList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent> { }
}
