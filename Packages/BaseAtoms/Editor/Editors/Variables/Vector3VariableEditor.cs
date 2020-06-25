using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Vector3`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Vector3Variable))]
    public sealed class Vector3VariableEditor : AtomVariableEditor<Vector3, Vector3Pair> { }
}
