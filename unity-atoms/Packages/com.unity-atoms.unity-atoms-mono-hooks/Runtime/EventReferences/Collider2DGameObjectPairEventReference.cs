using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `Collider2DGameObjectPair`. Inherits from `AtomEventReference&lt;Collider2DGameObjectPair, Collider2DGameObjectVariable, Collider2DGameObjectPairEvent, Collider2DGameObjectVariableInstancer, Collider2DGameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DGameObjectPairEventReference : AtomEventReference<
        Collider2DGameObjectPair,
        Collider2DGameObjectVariable,
        Collider2DGameObjectPairEvent,
        Collider2DGameObjectVariableInstancer,
        Collider2DGameObjectPairEventInstancer>, IGetEvent 
    { }
}
