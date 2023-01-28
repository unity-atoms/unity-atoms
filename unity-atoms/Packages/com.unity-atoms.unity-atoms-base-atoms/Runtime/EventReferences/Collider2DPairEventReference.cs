using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Collider2DPair`. Inherits from `AtomEventReference&lt;Collider2DPair, Collider2DVariable, Collider2DPairEvent, Collider2DVariableInstancer, Collider2DPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DPairEventReference : AtomEventReference<
        Collider2DPair,
        Collider2DVariable,
        Collider2DPairEvent,
        Collider2DVariableInstancer,
        Collider2DPairEventInstancer>, IGetEvent 
    { }
}
