using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Vector2`. Inherits from `AtomListener&lt;Vector2, Vector2, Vector2Vector2Action, Vector2Vector2Event, Vector2Vector2UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2 - Vector2")]
    public sealed class Vector2Vector2Listener : AtomListener<
        Vector2,
        Vector2,
        Vector2Vector2Action,
        Vector2Vector2Event,
        Vector2Vector2UnityEvent>
    { }
}
