using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Vector3`. Inherits from `AtomEventReference&lt;Vector3, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3EventReference : AtomEventReference<
        Vector3,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer> { }
}
