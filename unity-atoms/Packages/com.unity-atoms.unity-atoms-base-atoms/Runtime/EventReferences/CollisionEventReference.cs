using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Collision`. Inherits from `AtomEventReference&lt;Collision, CollisionVariable, CollisionEvent, CollisionVariableInstancer, CollisionEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionEventReference : AtomEventReference<
        Collision,
        CollisionVariable,
        CollisionEvent,
        CollisionVariableInstancer,
        CollisionEventInstancer>, IGetEvent 
    { }
}
