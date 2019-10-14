using UnityEngine;

namespace UnityAtoms.Mobile
{
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TouchUserInput", fileName = "TouchUserInputVariable")]
    public sealed class TouchUserInputVariable : EquatableAtomVariable<TouchUserInput, TouchUserInputEvent, TouchUserInputTouchUserInputEvent> { }
}
