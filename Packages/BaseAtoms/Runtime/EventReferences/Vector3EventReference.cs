using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Vector3`. Inherits from `AtomEventReference&lt;Vector3, Vector3Variable, Vector3Event, Vector3VariableInstancer, Vector3EventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3EventReference : AtomEventReference<
        Vector3,
        Vector3Variable,
        Vector3Event,
        Vector3VariableInstancer,
        Vector3EventInstancer>, IGetEvent 
    { }
}
