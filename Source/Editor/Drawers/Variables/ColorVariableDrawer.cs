#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColorVariable))]
    public class ColorVariableDrawer : AtomDrawer<ColorVariable> { }
}
#endif
