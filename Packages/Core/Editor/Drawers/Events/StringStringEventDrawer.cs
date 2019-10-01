#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(StringStringEvent))]
    public class StringStringEventDrawer : AtomDrawer<StringStringEvent> { }
}
#endif
