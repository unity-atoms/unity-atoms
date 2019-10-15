#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collider`. Inherits from `AtomDrawer&lt;ColliderVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColliderVariable))]
    public class ColliderVariableDrawer : AtomDrawer<ColliderVariable> { }
}
#endif
