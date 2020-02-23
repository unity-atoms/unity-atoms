using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Collider2D`. Inherits from `AtomX2Listener&lt;Collider2D, Collider2DCollider2DAction, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer, Collider2DCollider2DEventReference, Collider2DCollider2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D x 2 Listener")]
    public sealed class Collider2DCollider2DListener : AtomX2Listener<
        Collider2D,
        Collider2DCollider2DAction,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DCollider2DEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer,
        Collider2DCollider2DEventReference,
        Collider2DCollider2DUnityEvent>
    { }
}
