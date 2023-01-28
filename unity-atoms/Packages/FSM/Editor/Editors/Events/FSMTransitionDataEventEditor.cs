#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// Event property drawer of type `FSMTransitionData`. Inherits from `AtomEventEditor&lt;FSMTransitionData, FSMTransitionDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FSMTransitionDataEvent))]
    public sealed class FSMTransitionDataEventEditor : AtomEventEditor<FSMTransitionData, FSMTransitionDataEvent> { }
}
#endif
