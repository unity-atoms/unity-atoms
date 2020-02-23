using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `Collider`. Inherits from `AtomEventX2Reference&lt;Collider, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderColliderEventReference : AtomEventX2Reference<
        Collider,
        ColliderVariable,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer> { }
}
