using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `CollisionPair`. Inherits from `AtomEventReference&lt;CollisionPair, CollisionVariable, CollisionPairEvent, CollisionVariableInstancer, CollisionPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionPairEventReference : AtomEventReference<
        CollisionPair,
        CollisionVariable,
        CollisionPairEvent,
        CollisionVariableInstancer,
        CollisionPairEventInstancer>, IGetEvent 
    { }
}
