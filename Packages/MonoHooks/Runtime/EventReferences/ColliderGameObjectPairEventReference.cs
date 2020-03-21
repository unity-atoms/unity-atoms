using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `ColliderGameObjectPair`. Inherits from `AtomEventReference&lt;ColliderGameObjectPair, ColliderGameObjectVariable, ColliderGameObjectPairEvent, ColliderGameObjectVariableInstancer, ColliderGameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectPairEventReference : AtomEventReference<
        ColliderGameObjectPair,
        ColliderGameObjectVariable,
        ColliderGameObjectPairEvent,
        ColliderGameObjectVariableInstancer,
        ColliderGameObjectPairEventInstancer>, IGetEvent 
    { }
}
