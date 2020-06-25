using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Vector2`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Vector2Variable))]
    public sealed class Vector2VariableEditor : AtomVariableEditor<Vector2, Vector2Pair> { }
}
