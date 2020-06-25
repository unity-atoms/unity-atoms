using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collider`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ColliderVariable))]
    public sealed class ColliderVariableEditor : AtomVariableEditor<Collider, ColliderPair> { }
}
