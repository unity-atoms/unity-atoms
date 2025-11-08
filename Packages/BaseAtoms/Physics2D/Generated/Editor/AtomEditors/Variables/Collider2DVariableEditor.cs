using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityEngine.Collider2D`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Collider2DVariable))]
    public sealed class Collider2DVariableEditor : AtomVariableEditor<UnityEngine.Collider2D, Collider2DPair> { }
}
