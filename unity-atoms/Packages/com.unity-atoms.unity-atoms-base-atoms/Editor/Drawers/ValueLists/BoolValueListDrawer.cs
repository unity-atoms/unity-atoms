#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `bool`. Inherits from `AtomDrawer&lt;BoolValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolValueList))]
    public class BoolValueListDrawer : AtomDrawer<BoolValueList> { }
}
#endif
