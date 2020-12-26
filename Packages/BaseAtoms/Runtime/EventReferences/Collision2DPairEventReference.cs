using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Collision2DPair`. Inherits from `AtomEventReference&lt;Collision2DPair, Collision2DVariable, Collision2DPairEvent, Collision2DVariableInstancer, Collision2DPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DPairEventReference : AtomEventReference<
        Collision2DPair,
        Collision2DVariable,
        Collision2DPairEvent,
        Collision2DVariableInstancer,
        Collision2DPairEventInstancer>, IGetEvent 
    { }
}
