#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `int`. Inherits from `AtomDrawer&lt;IntList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntList))]
    public class IntListDrawer : AtomDrawer<IntList> { }
}
#endif
