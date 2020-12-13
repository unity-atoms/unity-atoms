using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// Event of type `PlayerInput`. Inherits from `AtomEvent&lt;PlayerInput&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/PlayerInput", fileName = "PlayerInputEvent")]
    public sealed class PlayerInputEvent : AtomEvent<PlayerInput>
    {
    }
}
