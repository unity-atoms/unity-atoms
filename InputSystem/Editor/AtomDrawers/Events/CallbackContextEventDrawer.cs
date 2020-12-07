#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `CallbackContext`. Inherits from `AtomDrawer&lt;CallbackContextEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CallbackContextEvent))]
    public class CallbackContextEventDrawer : AtomDrawer<CallbackContextEvent> { }
}
#endif
