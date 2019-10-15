using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Collider2D`. Inherits from `AtomListener&lt;Collider2D, Collider2D, Collider2DCollider2DAction, Collider2DCollider2DEvent, Collider2DCollider2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D - Collider2D")]
    public sealed class Collider2DCollider2DListener : AtomListener<
        Collider2D,
        Collider2D,
        Collider2DCollider2DAction,
        Collider2DCollider2DEvent,
        Collider2DCollider2DUnityEvent>
    { }
}
