using UnityEngine;

namespace UnityAtoms.Mobile
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TouchUserInput", fileName = "TouchUserInputVariable")]
    public sealed class TouchUserInputVariable : EquatableAtomVariable<TouchUserInput, TouchUserInputEvent, TouchUserInputTouchUserInputEvent> { }
}
