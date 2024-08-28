#if PACKAGE_UNITY_PHYSICS2D
using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collision2D`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Collision2DVariable))]
    public sealed class Collision2DVariableEditor : AtomVariableEditor<Collision2D, Collision2DPair> { }
}
#endif
