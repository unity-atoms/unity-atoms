using System;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event Reference of type `TouchUserInput`. Inherits from `AtomEventReference&lt;TouchUserInput, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputVariableInstancer, TouchUserInputEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TouchUserInputEventReference : AtomEventReference<
        TouchUserInput,
        TouchUserInputVariable,
        TouchUserInputEvent,
        TouchUserInputVariableInstancer,
        TouchUserInputEventInstancer>, IGetEvent 
    { }
}
