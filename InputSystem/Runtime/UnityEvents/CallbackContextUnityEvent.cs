using System;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// None generic Unity Event of type `CallbackContext`. Inherits from `UnityEvent&lt;CallbackContext&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CallbackContextUnityEvent : UnityEvent<InputAction.CallbackContext> { }
}
