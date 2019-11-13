using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Collider2D`. Inherits from `AtomListener&lt;Collider2D, Collider2DAction, Collider2DEvent, Collider2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D Listener")]
    public sealed class Collider2DListener : AtomListener<
        Collider2D,
        Collider2DAction,
        Collider2DEvent,
        Collider2DUnityEvent>
    { }
}
