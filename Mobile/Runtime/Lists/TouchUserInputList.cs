using UnityEngine;

namespace UnityAtoms.Mobile
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/TouchUserInput", fileName = "TouchUserInputList")]
    public sealed class TouchUserInputList : AtomList<TouchUserInput, TouchUserInputEvent> { }
}
