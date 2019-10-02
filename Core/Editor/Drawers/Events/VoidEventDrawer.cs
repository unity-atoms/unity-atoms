#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(VoidEvent))]
    public class VoidEventDrawer : AtomDrawer<VoidEvent> { }
}
#endif
