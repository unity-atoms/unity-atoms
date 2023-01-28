using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `QuaternionPair`. Inherits from `AtomEventReference&lt;QuaternionPair, QuaternionVariable, QuaternionPairEvent, QuaternionVariableInstancer, QuaternionPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class QuaternionPairEventReference : AtomEventReference<
        QuaternionPair,
        QuaternionVariable,
        QuaternionPairEvent,
        QuaternionVariableInstancer,
        QuaternionPairEventInstancer>, IGetEvent 
    { }
}
