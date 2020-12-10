#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `double`. Inherits from `AtomDrawer&lt;DoubleValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DoubleValueList))]
    public class DoubleValueListDrawer : AtomDrawer<DoubleValueList> { }
}
#endif
