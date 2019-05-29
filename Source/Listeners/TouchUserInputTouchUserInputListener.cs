using UnityEngine;

namespace UnityAtoms.Mobile
{
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput - TouchUserInput")]
    public sealed class TouchUserInputTouchUserInputListener : GameEventListener<
        TouchUserInput,
        TouchUserInput,
        TouchUserInputTouchUserInputAction,
        TouchUserInputTouchUserInputGameEvent,
        UnityTouchUserInputTouchUserInputEvent>
    { }
}

