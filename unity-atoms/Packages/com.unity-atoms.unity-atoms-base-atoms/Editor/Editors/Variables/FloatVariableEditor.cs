using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `float`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(FloatVariable))]
    public sealed class FloatVariableEditor : AtomVariableEditor<float, FloatPair> { }
}
