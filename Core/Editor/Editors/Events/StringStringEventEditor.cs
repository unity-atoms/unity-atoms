#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;string, string&gt;`. Inherits from `AtomEventEditor&lt;string, string, StringEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(StringStringEvent))]
    public sealed class StringStringEventEditor : AtomEventEditor<string, string, StringStringEvent> { }
}
#endif
