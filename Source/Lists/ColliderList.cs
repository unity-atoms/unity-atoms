using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider", fileName = "ColliderList")]
    public sealed class ColliderList : AtomList<Collider, ColliderEvent> { }
}
