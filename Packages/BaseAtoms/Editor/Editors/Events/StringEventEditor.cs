#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `string`. Inherits from `AtomEventEditor&lt;string, StringEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(StringEvent))]
    public sealed class StringEventEditor : AtomEventEditor<string, StringEvent> { }
}
#endif
