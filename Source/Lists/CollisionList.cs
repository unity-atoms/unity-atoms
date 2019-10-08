using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collision", fileName = "CollisionList")]
    public sealed class CollisionList : AtomList<Collision, CollisionEvent> { }
}
