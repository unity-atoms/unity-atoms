using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Collision`. Inherits from `AtomVariable&lt;Collision, CollisionPair, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision", fileName = "CollisionVariable")]
    public sealed class CollisionVariable : AtomVariable<Collision, CollisionPair, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction>
    {
        protected override bool ValueEquals(Collision other)
        {
            return _value == other;
        }
    }
}
