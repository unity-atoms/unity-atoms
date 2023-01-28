#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `int`. Inherits from `AtomDrawer&lt;IntValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntValueList))]
    public class IntValueListDrawer : AtomDrawer<IntValueList> { }
}
#endif
