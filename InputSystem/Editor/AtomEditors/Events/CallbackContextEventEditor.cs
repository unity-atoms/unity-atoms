#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `CallbackContext`. Inherits from `AtomEventEditor&lt;CallbackContext, CallbackContextEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CallbackContextEvent))]
    public sealed class CallbackContextEventEditor : AtomEventEditor<InputAction.CallbackContext, CallbackContextEvent> { }
}
#endif
