#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MonoHooks.Editor
{
    /// <summary>
    /// Constant property drawer of type `ColliderGameObject`. Inherits from `AtomDrawer&lt;ColliderGameObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderGameObjectConstant))]
    public class ColliderGameObjectConstantDrawer : VariableDrawer<ColliderGameObjectConstant> { }
}
#endif
