using UnityEngine;

namespace UnityAtoms.Mobile
{
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput")]
    public sealed class TouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputEvent,
        TouchUserInputUnityEvent>
    { }
}

