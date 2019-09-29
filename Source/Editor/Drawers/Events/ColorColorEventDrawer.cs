#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColorColorEvent))]
    public class ColorColorEventDrawer : AtomDrawer<ColorColorEvent> { }
}
#endif
