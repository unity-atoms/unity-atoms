using UnityEngine;

namespace UnityAtoms.Mobile
{
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput")]
    public sealed class TouchUserInputListener : GameEventListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputGameEvent,
        UnityTouchUserInputEvent>
    { }
}

