using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `bool`. Inherits from `AtomListener&lt;bool, bool, BoolBoolAction, BoolBoolEvent, BoolBoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool x 2 Listener")]
    public sealed class BoolBoolListener : AtomListener<
        bool,
        bool,
        BoolBoolAction,
        BoolBoolEvent,
        BoolBoolUnityEvent>
    { }
}
