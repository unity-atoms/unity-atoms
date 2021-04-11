using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable Inspector of type `CollisionGameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CollisionGameObjectVariable))]
    public sealed class CollisionGameObjectVariableEditor : AtomVariableEditor<CollisionGameObject> { }
}
