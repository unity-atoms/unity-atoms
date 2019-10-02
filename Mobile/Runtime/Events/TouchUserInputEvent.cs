using UnityEngine;

namespace UnityAtoms.Mobile
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TouchUserInput", fileName = "TouchUserInputEvent")]
    public sealed class TouchUserInputEvent : AtomEvent<TouchUserInput> { }
}
