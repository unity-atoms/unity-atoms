#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `string`. Inherits from `AtomDrawer&lt;StringValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringValueList))]
    public class StringValueListDrawer : AtomDrawer<StringValueList> { }
}
#endif
