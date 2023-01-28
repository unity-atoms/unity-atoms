using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `int`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(IntVariable))]
    public sealed class IntVariableEditor : AtomVariableEditor<int, IntPair> { }
}
