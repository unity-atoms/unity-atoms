#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Event property drawer of type `TouchUserInputPair`. Inherits from `AtomEventEditor&lt;TouchUserInputPair, TouchUserInputPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TouchUserInputPairEvent))]
    public sealed class TouchUserInputPairEventEditor : AtomEventEditor<TouchUserInputPair, TouchUserInputPairEvent> { }
}
#endif
