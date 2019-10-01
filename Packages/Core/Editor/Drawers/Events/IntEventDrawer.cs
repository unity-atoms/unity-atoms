#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(IntEvent))]
    public class IntEventDrawer : AtomDrawer<IntEvent> { }
}
#endif
