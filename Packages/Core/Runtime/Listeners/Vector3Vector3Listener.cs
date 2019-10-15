using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Vector3`. Inherits from `AtomListener&lt;Vector3, Vector3, Vector3Vector3Action, Vector3Vector3Event, Vector3Vector3UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3 - Vector3")]
    public sealed class Vector3Vector3Listener : AtomListener<
        Vector3,
        Vector3,
        Vector3Vector3Action,
        Vector3Vector3Event,
        Vector3Vector3UnityEvent>
    { }
}
