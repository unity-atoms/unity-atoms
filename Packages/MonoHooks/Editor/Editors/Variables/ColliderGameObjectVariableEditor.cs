#if PACKAGE_UNITY_PHYSICS
using UnityEditor;
using UnityAtoms.Editor;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable Inspector of type `ColliderGameObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ColliderGameObjectVariable))]
    public sealed class ColliderGameObjectVariableEditor : AtomVariableEditor<ColliderGameObject, ColliderGameObjectPair> { }
}
#endif
