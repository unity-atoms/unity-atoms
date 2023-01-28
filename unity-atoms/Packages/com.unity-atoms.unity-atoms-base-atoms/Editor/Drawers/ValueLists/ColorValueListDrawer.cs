#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorValueList))]
    public class ColorValueListDrawer : AtomDrawer<ColorValueList> { }
}
#endif
