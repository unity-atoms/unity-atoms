using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector2`. Inherits from `EquatableAtomReference&lt;Vector2, Vector2Constant, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2Reference : EquatableAtomReference<
        Vector2,
        Vector2Constant,
        Vector2Variable,
        Vector2Event,
        Vector2Vector2Event,
        Vector2Vector2Function,
        Vector2VariableInstancer>, IEquatable<Vector2Reference>
    {
        public bool Equals(Vector2Reference other) { return base.Equals(other); }
    }
}
