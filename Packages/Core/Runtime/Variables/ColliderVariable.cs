using System;
using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collider", fileName = "ColliderVariable")]
    public sealed class ColliderVariable : AtomVariable<Collider, ColliderEvent, ColliderColliderEvent>
    {
        protected override bool AreEqual(Collider first, Collider second)
        {
            return (first == null && second == null) || first != null && second != null && first == second;
        }
    }
}
