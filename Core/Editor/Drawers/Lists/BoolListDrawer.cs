#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `bool`. Inherits from `AtomDrawer&lt;BoolList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolList))]
    public class BoolListDrawer : AtomDrawer<BoolList> { }
}
#endif
