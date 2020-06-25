#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `bool`. Inherits from `AtomEventEditor&lt;bool, BoolEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BoolEvent))]
    public sealed class BoolEventEditor : AtomEventEditor<bool, BoolEvent> { }
}
#endif
