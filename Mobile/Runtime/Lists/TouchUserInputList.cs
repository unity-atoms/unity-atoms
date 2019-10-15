using UnityEngine;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// List of type `TouchUserInput`. Inherits from `AtomList&lt;TouchUserInput, TouchUserInputEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/TouchUserInput", fileName = "TouchUserInputList")]
    public sealed class TouchUserInputList : AtomList<TouchUserInput, TouchUserInputEvent> { }
}
