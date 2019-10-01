#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(StringEvent))]
    public class StringEventDrawer : AtomDrawer<StringEvent> { }
}
#endif
