using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `CollisionGameObjectPair`. Inherits from `AtomEventReference&lt;CollisionGameObjectPair, CollisionGameObjectVariable, CollisionGameObjectPairEvent, CollisionGameObjectVariableInstancer, CollisionGameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectPairEventReference : AtomEventReference<
        CollisionGameObjectPair,
        CollisionGameObjectVariable,
        CollisionGameObjectPairEvent,
        CollisionGameObjectVariableInstancer,
        CollisionGameObjectPairEventInstancer>, IGetEvent 
    { }
}
