using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityEngine.Collision`. Inherits from `AtomEventReference&lt;UnityEngine.Collision, CollisionVariable, CollisionEvent, CollisionVariableInstancer, CollisionEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionEventReference : AtomEventReference<
        UnityEngine.Collision,
        CollisionVariable,
        CollisionEvent,
        CollisionVariableInstancer,
        CollisionEventInstancer>, IGetEvent 
    { }
}
