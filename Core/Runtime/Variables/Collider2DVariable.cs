using System;
using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collider2D", fileName = "Collider2DVariable")]
    public sealed class Collider2DVariable : AtomVariable<Collider2D, Collider2DEvent, Collider2DCollider2DEvent>
    {
        protected override bool AreEqual(Collider2D first, Collider2D second)
        {
            return (first == null && second == null) || first != null && second != null && first == second;
        }
    }
}
