#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Event property drawer of type `TouchUserInputPair`. Inherits from `AtomDrawer&lt;TouchUserInputPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputPairEvent))]
    public class TouchUserInputPairEventDrawer : AtomDrawer<TouchUserInputPairEvent> { }
}
#endif
