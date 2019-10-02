using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider2D", fileName = "Collider2DList")]
    public sealed class Collider2DList : AtomList<Collider2D, Collider2DEvent> { }
}
