#if PACKAGE_UNITY_PHYSICS
using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collision`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CollisionVariable))]
    public sealed class CollisionVariableEditor : AtomVariableEditor<Collision, CollisionPair> { }
}
#endif
