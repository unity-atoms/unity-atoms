#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColorList))]
    public class ColorListDrawer : AtomDrawer<ColorList> { }
}
#endif
