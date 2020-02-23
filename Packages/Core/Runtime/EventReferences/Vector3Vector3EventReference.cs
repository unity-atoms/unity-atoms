using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `Vector3`. Inherits from `AtomEventX2Reference&lt;Vector3, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Vector3EventReference : AtomEventX2Reference<
        Vector3,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer> { }
}
