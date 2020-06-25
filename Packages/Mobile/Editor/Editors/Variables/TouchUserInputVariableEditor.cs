using UnityEditor;
using UnityAtoms.Editor;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Variable Inspector of type `TouchUserInput`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(TouchUserInputVariable))]
    public sealed class TouchUserInputVariableEditor : AtomVariableEditor<TouchUserInput, TouchUserInputPair> { }
}
