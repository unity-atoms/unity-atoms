using UnityEditor;
using UnityAtoms.Editor;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Variable Inspector of type `SceneField`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SceneFieldVariable))]
    public sealed class SceneFieldVariableEditor : AtomVariableEditor<SceneField, SceneFieldPair> { }
}
