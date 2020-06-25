using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `GameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(GameObjectVariable))]
    public sealed class GameObjectVariableEditor : AtomVariableEditor<GameObject, GameObjectPair> { }
}
