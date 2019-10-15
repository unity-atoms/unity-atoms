#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatList))]
    public class FloatListDrawer : AtomDrawer<FloatList> { }
}
#endif
