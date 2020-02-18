using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Collider2D`. Inherits from `AtomListener&lt;Collider2D, Collider2DAction, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer, Collider2DEventReference, Collider2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D Listener")]
    public sealed class Collider2DListener : AtomListener<
        Collider2D,
        Collider2DAction,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DCollider2DEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer,
        Collider2DEventReference,
        Collider2DUnityEvent>
    { }
}
