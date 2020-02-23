using System;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Reference of type `TouchUserInput`. Inherits from `EquatableAtomReference&lt;TouchUserInput, TouchUserInputConstant, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TouchUserInputReference : EquatableAtomReference<
        TouchUserInput,
        TouchUserInputConstant,
        TouchUserInputVariable,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputFunction,
        TouchUserInputVariableInstancer>, IEquatable<TouchUserInputReference>
    {
        public TouchUserInputReference() : base() { }
        public TouchUserInputReference(TouchUserInput value) : base(value) { }
        public bool Equals(TouchUserInputReference other) { return base.Equals(other); }
    }
}
