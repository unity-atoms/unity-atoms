using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Vector3`. Inherits from `AtomListener&lt;Vector3, Vector3Action, Vector3Event, Vector3UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3")]
    public sealed class Vector3Listener : AtomListener<
        Vector3,
        Vector3Action,
        Vector3Event,
        Vector3UnityEvent>
    { }
}
