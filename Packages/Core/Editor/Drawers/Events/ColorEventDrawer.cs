#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColorEvent))]
    public class ColorEventDrawer : AtomDrawer<ColorEvent> { }
}
#endif
