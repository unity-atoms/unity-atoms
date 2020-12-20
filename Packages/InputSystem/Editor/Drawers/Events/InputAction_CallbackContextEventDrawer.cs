#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `InputAction.CallbackContext`. Inherits from `AtomDrawer&lt;InputAction_CallbackContextEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(InputAction_CallbackContextEvent))]
    public class InputAction_CallbackContextEventDrawer : AtomDrawer<InputAction_CallbackContextEvent> { }
}
#endif
