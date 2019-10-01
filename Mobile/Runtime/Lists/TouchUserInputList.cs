using UnityEngine;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/TouchUserInput", fileName = "TouchUserInputList")]
    public sealed class TouchUserInputList : AtomList<TouchUserInput, TouchUserInputEvent> { }
}
