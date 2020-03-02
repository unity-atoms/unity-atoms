using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `bool`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(BoolVariable))]
    public sealed class BoolVariableEditor : AtomVariableEditor<bool, BoolPair> { }
}
