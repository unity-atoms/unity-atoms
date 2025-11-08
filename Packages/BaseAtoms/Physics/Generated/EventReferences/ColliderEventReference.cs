using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityEngine.Collider`. Inherits from `AtomEventReference&lt;UnityEngine.Collider, ColliderVariable, ColliderEvent, ColliderVariableInstancer, ColliderEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderEventReference : AtomEventReference<
        UnityEngine.Collider,
        ColliderVariable,
        ColliderEvent,
        ColliderVariableInstancer,
        ColliderEventInstancer>, IGetEvent 
    { }
}
