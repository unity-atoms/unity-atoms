using UnityEngine;

namespace UnityAtoms.Mobile
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/TouchUserInput", fileName = "SetTouchUserInputVariableValue")]
    public sealed class SetTouchUserInputVariableValue : SetVariableValue<
        TouchUserInput,
        TouchUserInputVariable,
        TouchUserInputReference,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent>
    { }
}
