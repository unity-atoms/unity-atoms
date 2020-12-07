using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// Event Instancer of type `CallbackContext`. Inherits from `AtomEventInstancer&lt;CallbackContext, CallbackContextEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CallbackContext Event Instancer")]
    public class CallbackContextEventInstancer : AtomEventInstancer<InputAction.CallbackContext, CallbackContextEvent> { }
}
