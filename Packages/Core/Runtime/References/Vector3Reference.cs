using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector3`. Inherits from `EquatableAtomReference&lt;Vector3, Vector3Constant, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Reference : EquatableAtomReference<
        Vector3,
        Vector3Constant,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer>, IEquatable<Vector3Reference>
    {
        public bool Equals(Vector3Reference other) { return base.Equals(other); }
    }
}
