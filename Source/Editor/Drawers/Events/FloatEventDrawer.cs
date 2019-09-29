#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(FloatEvent))]
    public class FloatEventDrawer : AtomDrawer<FloatEvent> { }
}
#endif
