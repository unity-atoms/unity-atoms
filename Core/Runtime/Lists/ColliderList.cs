using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider", fileName = "ColliderList")]
    public sealed class ColliderList : AtomList<Collider, ColliderEvent> { }
}
