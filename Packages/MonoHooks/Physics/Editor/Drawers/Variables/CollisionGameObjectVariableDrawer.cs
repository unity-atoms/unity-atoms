#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Variable property drawer of type `CollisionGameObject`. Inherits from `AtomDrawer&lt;CollisionGameObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionGameObjectVariable))]
    public class CollisionGameObjectVariableDrawer : VariableDrawer<CollisionGameObjectVariable> { }
}
#endif
