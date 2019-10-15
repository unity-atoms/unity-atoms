#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// List property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorList))]
    public class ColorListDrawer : AtomDrawer<ColorList> { }
}
#endif
