using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityEngine.Collision`. Inherits from `AtomVariable&lt;UnityEngine.Collision, CollisionPair, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision", fileName = "CollisionVariable")]
    public sealed class CollisionVariable : AtomVariable<UnityEngine.Collision, CollisionPair, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction>
    {
        protected override bool ValueEquals(UnityEngine.Collision other)
        {
            throw new NotImplementedException();
        }
    }
}
