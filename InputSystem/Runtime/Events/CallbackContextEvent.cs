using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// Event of type `CallbackContext`. Inherits from `AtomEvent&lt;CallbackContext&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Events/Callback Context", fileName = "CallbackContextEvent")]
    public sealed class CallbackContextEvent : AtomEvent<InputAction.CallbackContext>
    {
    }
}
