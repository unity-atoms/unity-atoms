using UnityEngine;
using UnityAtoms;

namespace UnityAtoms.Mobile
{
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput - TouchUserInput")]
    public sealed class TouchUserInputTouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInput,
        TouchUserInputTouchUserInputAction,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputUnityEvent>
    { }
}

