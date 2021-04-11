using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event of type `TouchUserInput`. Inherits from `AtomEvent&lt;TouchUserInput&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TouchUserInput", fileName = "TouchUserInputEvent")]
    public sealed class TouchUserInputEvent : AtomEvent<TouchUserInput>
    {
    }
}
