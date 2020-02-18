using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Collider`. Inherits from `AtomListener&lt;Collider, ColliderAction, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer, ColliderEventReference, ColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider Listener")]
    public sealed class ColliderListener : AtomListener<
        Collider,
        ColliderAction,
        ColliderVariable,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer,
        ColliderEventReference,
        ColliderUnityEvent>
    { }
}
