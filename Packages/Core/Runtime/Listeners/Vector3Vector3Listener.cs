using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Vector3`. Inherits from `AtomX2Listener&lt;Vector3, Vector3Vector3Action, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer, Vector3Vector3EventReference, Vector3Vector3UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3 x 2 Listener")]
    public sealed class Vector3Vector3Listener : AtomX2Listener<
        Vector3,
        Vector3Vector3Action,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer,
        Vector3Vector3EventReference,
        Vector3Vector3UnityEvent>
    { }
}
