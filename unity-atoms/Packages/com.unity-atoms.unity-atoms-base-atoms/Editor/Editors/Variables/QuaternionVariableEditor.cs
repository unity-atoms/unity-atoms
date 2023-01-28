using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Quaternion`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(QuaternionVariable))]
    public sealed class QuaternionVariableEditor : AtomVariableEditor<Quaternion, QuaternionPair> { }
}
