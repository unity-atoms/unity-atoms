#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Vector2`. Inherits from `AtomDrawer&lt;Vector2ValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2ValueList))]
    public class Vector2ValueListDrawer : AtomDrawer<Vector2ValueList> { }
}
#endif
