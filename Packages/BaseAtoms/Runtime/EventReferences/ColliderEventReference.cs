using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Collider`. Inherits from `AtomEventReference&lt;Collider, ColliderVariable, ColliderEvent, ColliderVariableInstancer, ColliderEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderEventReference : AtomEventReference<
        Collider,
        ColliderVariable,
        ColliderEvent,
        ColliderVariableInstancer,
        ColliderEventInstancer>, IGetEvent 
    { }
}
