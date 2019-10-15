#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `string`. Inherits from `AtomDrawer&lt;StringStringEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringStringEvent))]
    public class StringStringEventDrawer : AtomDrawer<StringStringEvent> { }
}
#endif
