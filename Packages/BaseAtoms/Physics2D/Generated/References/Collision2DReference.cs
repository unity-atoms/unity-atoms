using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Collision2D`. Inherits from `AtomReference&lt;UnityEngine.Collision2D, Collision2DPair, Collision2DConstant, Collision2DVariable, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction, Collision2DVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DReference : AtomReference<
        UnityEngine.Collision2D,
        Collision2DPair,
        Collision2DConstant,
        Collision2DVariable,
        Collision2DEvent,
        Collision2DPairEvent,
        Collision2DCollision2DFunction,
        Collision2DVariableInstancer>, IEquatable<Collision2DReference>
    {
        public Collision2DReference() : base() { }
        public Collision2DReference(UnityEngine.Collision2D value) : base(value) { }
        public bool Equals(Collision2DReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Collision2D other)
        {
            throw new NotImplementedException();
        }
    }
}
