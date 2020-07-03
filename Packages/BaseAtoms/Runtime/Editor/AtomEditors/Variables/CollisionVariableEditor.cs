using UnityEngine;
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collision`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor (typeof (CollisionVariable))]
    public sealed class CollisionVariableEditor : AtomVariableEditor<Collision, CollisionPair> { }
}