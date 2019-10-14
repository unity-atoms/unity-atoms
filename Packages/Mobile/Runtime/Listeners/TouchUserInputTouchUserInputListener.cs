using UnityEngine;

namespace UnityAtoms.Mobile
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput - TouchUserInput")]
    public sealed class TouchUserInputTouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInput,
        TouchUserInputTouchUserInputAction,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputUnityEvent>
    { }
}
