#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Color`. Inherits from `AtomDrawer&lt;ColorConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ColorConstant))]
    public class ColorConstantDrawer : AtomDrawer<ColorConstant> { }
}
#endif
