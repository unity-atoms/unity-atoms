using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider", fileName = "ColliderList")]
    public sealed class ColliderList : AtomList<Collider, ColliderEvent> { }
}
