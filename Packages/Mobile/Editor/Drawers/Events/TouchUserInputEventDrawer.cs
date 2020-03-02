#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Event property drawer of type `TouchUserInput`. Inherits from `AtomDrawer&lt;TouchUserInputEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputEvent))]
    public class TouchUserInputEventDrawer : AtomDrawer<TouchUserInputEvent> { }
}
#endif
