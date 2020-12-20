#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `InputAction.CallbackContext`. Inherits from `AtomEventEditor&lt;InputAction.CallbackContext, InputAction_CallbackContextEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(InputAction_CallbackContextEvent))]
    public sealed class InputAction_CallbackContextEventEditor : AtomEventEditor<InputAction.CallbackContext, InputAction_CallbackContextEvent> { }
}
#endif
