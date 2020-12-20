#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Vector3`. Inherits from `AtomDrawer&lt;Vector3ValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3ValueList))]
    public class Vector3ValueListDrawer : AtomDrawer<Vector3ValueList> { }
}
#endif
