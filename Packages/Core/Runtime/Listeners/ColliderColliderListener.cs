using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Collider`. Inherits from `AtomX2Listener&lt;Collider, ColliderColliderAction, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer, ColliderColliderEventReference, ColliderColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider x 2 Listener")]
    public sealed class ColliderColliderListener : AtomX2Listener<
        Collider,
        ColliderColliderAction,
        ColliderVariable,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer,
        ColliderColliderEventReference,
        ColliderColliderUnityEvent>
    { }
}
