using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector3`. Inherits from `AtomReference&lt;Vector3, Vector3Constant, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Reference : AtomReference<
        Vector3,
        Vector3Constant,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer> { }
}
