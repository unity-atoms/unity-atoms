using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Collision2D`. Inherits from `AtomVariable&lt;Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision2D", fileName = "Collision2DVariable")]
    public sealed class Collision2DVariable : AtomVariable<Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction>
    {
        protected override bool ValueEquals(Collision2D other)
        {
            return _value == other;
        }
    }
}
