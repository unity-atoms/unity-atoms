#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `string`. Inherits from `AtomDrawer&lt;StringEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringEvent))]
    public class StringEventDrawer : AtomDrawer<StringEvent> { }
}
#endif
