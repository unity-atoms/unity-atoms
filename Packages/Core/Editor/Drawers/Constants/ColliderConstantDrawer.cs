#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderConstant))]
    public class ColliderConstantDrawer : AtomDrawer<ColliderConstant> { }
}
#endif
