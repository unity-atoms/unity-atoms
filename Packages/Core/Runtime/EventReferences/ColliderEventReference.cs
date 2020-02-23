using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Collider`. Inherits from `AtomEventReference&lt;Collider, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderEventReference : AtomEventReference<
        Collider,
        ColliderVariable,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer> { }
}
