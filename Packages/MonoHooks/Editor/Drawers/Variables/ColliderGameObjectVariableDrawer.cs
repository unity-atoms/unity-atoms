#if UNITY_2019_1_OR_NEWER && PACKAGE_UNITY_PHYSICS
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable property drawer of type `ColliderGameObject`. Inherits from `AtomDrawer&lt;ColliderGameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderGameObjectVariable))]
    public class ColliderGameObjectVariableDrawer : VariableDrawer<ColliderGameObjectVariable> { }
}
#endif
