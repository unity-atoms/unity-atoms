#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;bool, bool&gt;`. Inherits from `AtomEventEditor&lt;bool, bool, BoolEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BoolBoolEvent))]
    public sealed class BoolBoolEventEditor : AtomEventEditor<bool, bool, BoolBoolEvent> { }
}
#endif
