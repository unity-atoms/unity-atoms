using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Collider`. Inherits from `AtomVariable&lt;Collider, ColliderPair, ColliderEvent, ColliderPairEvent, ColliderColliderFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collider", fileName = "ColliderVariable")]
    public sealed class ColliderVariable : AtomVariable<Collider, ColliderPair, ColliderEvent, ColliderPairEvent, ColliderColliderFunction>
    {
        protected override bool ValueEquals(Collider other)
        {
            return (_value == null && other == null) || _value != null && other != null && _value == other;
        }
    }
}
