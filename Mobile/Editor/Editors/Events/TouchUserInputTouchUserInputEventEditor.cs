#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Mobile;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;TouchUserInput, TouchUserInput&gt;`. Inherits from `AtomEventEditor&lt;TouchUserInput, TouchUserInput, TouchUserInputEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TouchUserInputTouchUserInputEvent))]
    public sealed class TouchUserInputTouchUserInputEventEditor : AtomEventEditor<TouchUserInput, TouchUserInput, TouchUserInputTouchUserInputEvent> { }
}
#endif
