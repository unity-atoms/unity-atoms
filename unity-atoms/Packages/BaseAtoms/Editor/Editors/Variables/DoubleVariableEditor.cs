using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `double`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(DoubleVariable))]
    public sealed class DoubleVariableEditor : AtomVariableEditor<double, DoublePair> { }
}
