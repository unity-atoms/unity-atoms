#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderConstant))]
    public class ColliderConstantDrawer : VariableDrawer<ColliderConstant> { }
}
#endif
