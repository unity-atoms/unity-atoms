#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(FloatFloatEvent))]
    public class FloatFloatEventDrawer : AtomDrawer<FloatFloatEvent> { }
}
#endif
