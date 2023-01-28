#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.InputSystem.Editor
{
    /// <summary>
    /// Event property drawer of type `PlayerInput`. Inherits from `AtomDrawer&lt;PlayerInputEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(PlayerInputEvent))]
    public class PlayerInputEventDrawer : AtomDrawer<PlayerInputEvent> { }
}
#endif
