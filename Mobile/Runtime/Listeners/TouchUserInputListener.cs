using UnityEngine;

namespace UnityAtoms.Mobile
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput")]
    public sealed class TouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputEvent,
        TouchUserInputUnityEvent>
    { }
}
