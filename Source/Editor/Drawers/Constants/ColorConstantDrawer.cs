#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColorConstant))]
    public class ColorConstantDrawer : AtomDrawer<ColorConstant> { }
}
#endif
