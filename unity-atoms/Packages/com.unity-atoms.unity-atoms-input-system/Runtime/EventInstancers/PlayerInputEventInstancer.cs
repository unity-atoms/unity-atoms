using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// Event Instancer of type `PlayerInput`. Inherits from `AtomEventInstancer&lt;PlayerInput, PlayerInputEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/PlayerInput Event Instancer")]
    public class PlayerInputEventInstancer : AtomEventInstancer<PlayerInput, PlayerInputEvent> { }
}
