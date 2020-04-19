#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Event property drawer of type `TouchUserInput`. Inherits from `AtomEventEditor&lt;TouchUserInput, TouchUserInputEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TouchUserInputEvent))]
    public sealed class TouchUserInputEventEditor : AtomEventEditor<TouchUserInput, TouchUserInputEvent> { }
}
#endif
