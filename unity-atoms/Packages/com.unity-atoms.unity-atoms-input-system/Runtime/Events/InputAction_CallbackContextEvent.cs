using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// Event of type `InputAction.CallbackContext`. Inherits from `AtomEvent&lt;InputAction.CallbackContext&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/InputAction_CallbackContext", fileName = "InputAction_CallbackContextEvent")]
    public sealed class InputAction_CallbackContextEvent : AtomEvent<InputAction.CallbackContext>
    {
    }
}
