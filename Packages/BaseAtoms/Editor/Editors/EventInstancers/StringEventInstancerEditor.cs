#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `string`. Inherits from `AtomEventInstancerEditor&lt;string, StringEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(StringEventInstancer))]
    public sealed class StringEventInstancerEditor : AtomEventInstancerEditor<string, StringEvent> { }
}
#endif
