#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `InputAction.CallbackContext`. Inherits from `AtomDrawer&lt;InputAction.CallbackContextEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(InputAction.CallbackContextEvent))]
    public class InputAction.CallbackContextEventDrawer : AtomDrawer<InputAction.CallbackContextEvent> { }
}
#endif
