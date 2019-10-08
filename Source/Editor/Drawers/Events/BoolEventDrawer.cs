#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(BoolEvent))]
    public class BoolEventDrawer : AtomDrawer<BoolEvent> { }
}
#endif
