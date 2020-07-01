#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `bool`. Inherits from `AtomEventInstancerEditor&lt;bool, BoolEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BoolEventInstancer))]
    public sealed class BoolEventInstancerEditor : AtomEventInstancerEditor<bool, BoolEvent> { }
}
#endif
