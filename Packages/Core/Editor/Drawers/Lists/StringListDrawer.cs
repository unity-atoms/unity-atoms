#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `string`. Inherits from `AtomDrawer&lt;StringList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringList))]
    public class StringListDrawer : AtomDrawer<StringList> { }
}
#endif
