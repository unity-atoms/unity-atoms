using System;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference of type `Collision2DGameObjectPair`. Inherits from `AtomEventReference&lt;Collision2DGameObjectPair, Collision2DGameObjectVariable, Collision2DGameObjectPairEvent, Collision2DGameObjectVariableInstancer, Collision2DGameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DGameObjectPairEventReference : AtomEventReference<
        Collision2DGameObjectPair,
        Collision2DGameObjectVariable,
        Collision2DGameObjectPairEvent,
        Collision2DGameObjectVariableInstancer,
        Collision2DGameObjectPairEventInstancer>, IGetEvent 
    { }
}
