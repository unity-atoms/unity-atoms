#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderVariable))]
    public class ColliderVariableDrawer : VariableDrawer<ColliderVariable> { }
}
#endif
