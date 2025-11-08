using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityEngine.Collision2D`. Inherits from `AtomVariable&lt;UnityEngine.Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision2D", fileName = "Collision2DVariable")]
    public sealed class Collision2DVariable : AtomVariable<UnityEngine.Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction>
    {
        protected override bool ValueEquals(UnityEngine.Collision2D other)
        {
            throw new NotImplementedException();
        }
    }
}
