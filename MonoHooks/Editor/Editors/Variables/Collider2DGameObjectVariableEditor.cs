using UnityEditor;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable Inspector of type `Collider2DGameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Collider2DGameObjectVariable))]
    public sealed class Collider2DGameObjectVariableEditor : AtomVariableEditor<Collider2DGameObject, Collider2DGameObjectPair> { }
}
