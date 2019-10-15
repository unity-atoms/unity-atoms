using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Vector2`. Inherits from `AtomListener&lt;Vector2, Vector2Action, Vector2Event, Vector2UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2")]
    public sealed class Vector2Listener : AtomListener<
        Vector2,
        Vector2Action,
        Vector2Event,
        Vector2UnityEvent>
    { }
}
