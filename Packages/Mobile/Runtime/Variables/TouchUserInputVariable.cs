using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Variable of type `TouchUserInput`. Inherits from `EquatableAtomVariable&lt;TouchUserInput, TouchUserInputPair, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TouchUserInput", fileName = "TouchUserInputVariable")]
    public sealed class TouchUserInputVariable : EquatableAtomVariable<TouchUserInput, TouchUserInputPair, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction> { }
}
