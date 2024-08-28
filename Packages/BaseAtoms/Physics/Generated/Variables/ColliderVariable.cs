using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityEngine.Collider`. Inherits from `AtomVariable&lt;UnityEngine.Collider, ColliderPair, ColliderEvent, ColliderPairEvent, ColliderColliderFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collider", fileName = "ColliderVariable")]
    public sealed class ColliderVariable : AtomVariable<UnityEngine.Collider, ColliderPair, ColliderEvent, ColliderPairEvent, ColliderColliderFunction>
    {
        protected override bool ValueEquals(UnityEngine.Collider other)
        {
            throw new NotImplementedException();
        }
    }
}
