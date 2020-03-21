using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Reference of type `TouchUserInput`. Inherits from `EquatableAtomReference&lt;TouchUserInput, TouchUserInputPair, TouchUserInputConstant, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TouchUserInputReference : EquatableAtomReference<
        TouchUserInput,
        TouchUserInputPair,
        TouchUserInputConstant,
        TouchUserInputVariable,
        TouchUserInputEvent,
        TouchUserInputPairEvent,
        TouchUserInputTouchUserInputFunction,
        TouchUserInputVariableInstancer>, IEquatable<TouchUserInputReference>
    {
        public TouchUserInputReference() : base() { }
        public TouchUserInputReference(TouchUserInput value) : base(value) { }
        public bool Equals(TouchUserInputReference other) { return base.Equals(other); }
    }
}
