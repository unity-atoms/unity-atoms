#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// Event property drawer of type `FSMTransitionData`. Inherits from `AtomDrawer&lt;FSMTransitionDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FSMTransitionDataEvent))]
    public class FSMTransitionDataEventDrawer : AtomDrawer<FSMTransitionDataEvent> { }
}
#endif
