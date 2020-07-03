#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer (typeof (CollisionConstant))]
    public class CollisionConstantDrawer : VariableDrawer<CollisionConstant> { }
}
#endif