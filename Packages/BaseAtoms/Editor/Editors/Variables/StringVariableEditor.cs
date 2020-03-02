using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `string`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(StringVariable))]
    public sealed class StringVariableEditor : AtomVariableEditor<string, StringPair> { }
}
