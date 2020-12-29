#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Constant property drawer of type `CollisionGameObject`. Inherits from `AtomDrawer&lt;CollisionGameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionGameObjectConstant))]
    public class CollisionGameObjectConstantDrawer : VariableDrawer<CollisionGameObjectConstant> { }
}
#endif
