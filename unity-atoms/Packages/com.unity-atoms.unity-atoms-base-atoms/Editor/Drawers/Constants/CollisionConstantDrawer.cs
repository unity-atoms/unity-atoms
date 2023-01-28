#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionConstant))]
    public class CollisionConstantDrawer : VariableDrawer<CollisionConstant> { }
}
#endif
