#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(BoolBoolEvent))]
    public class BoolBoolEventDrawer : AtomDrawer<BoolBoolEvent> { }
}
#endif
