#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine.InputSystem;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `PlayerInput`. Inherits from `AtomEventEditor&lt;PlayerInput, PlayerInputEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(PlayerInputEvent))]
    public sealed class PlayerInputEventEditor : AtomEventEditor<PlayerInput, PlayerInputEvent> { }
}
#endif
