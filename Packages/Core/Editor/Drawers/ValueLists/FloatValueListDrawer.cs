#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatValueList))]
    public class FloatValueListDrawer : AtomDrawer<FloatValueList> { }
}
#endif
