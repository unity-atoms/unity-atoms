using System;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event Reference of type `TouchUserInputPair`. Inherits from `AtomEventReference&lt;TouchUserInputPair, TouchUserInputVariable, TouchUserInputPairEvent, TouchUserInputVariableInstancer, TouchUserInputPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TouchUserInputPairEventReference : AtomEventReference<
        TouchUserInputPair,
        TouchUserInputVariable,
        TouchUserInputPairEvent,
        TouchUserInputVariableInstancer,
        TouchUserInputPairEventInstancer>, IGetEvent 
    { }
}
