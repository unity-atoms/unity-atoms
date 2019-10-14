using UnityEngine;

namespace UnityAtoms.Mobile
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TouchUserInput", fileName = "TouchUserInputEvent")]
    public sealed class TouchUserInputEvent : AtomEvent<TouchUserInput> { }
}
