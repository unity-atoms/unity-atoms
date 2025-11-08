using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityEngine.Collision`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CollisionVariable))]
    public sealed class CollisionVariableEditor : AtomVariableEditor<UnityEngine.Collision, CollisionPair> { }
}
