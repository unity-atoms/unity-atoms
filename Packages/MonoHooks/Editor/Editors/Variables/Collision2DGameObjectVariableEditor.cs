using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collision2DGameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Collision2DGameObjectVariable))]
    public sealed class Collision2DGameObjectVariableEditor : AtomVariableEditor<Collision2DGameObject> { }
}
