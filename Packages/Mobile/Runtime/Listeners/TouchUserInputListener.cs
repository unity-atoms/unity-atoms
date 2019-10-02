using UnityEngine;

namespace UnityAtoms.Mobile
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput")]
    public sealed class TouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputEvent,
        TouchUserInputUnityEvent>
    { }
}
