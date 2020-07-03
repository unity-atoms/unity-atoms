using System;
using UnityEngine;

namespace UnityAtoms.BaseAtom
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
