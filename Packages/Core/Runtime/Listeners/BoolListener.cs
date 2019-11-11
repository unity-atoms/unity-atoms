using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `bool`. Inherits from `AtomListener&lt;bool, BoolAction, BoolEvent, BoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool Listener")]
    public sealed class BoolListener : AtomListener<
        bool,
        BoolAction,
        BoolEvent,
        BoolUnityEvent>
    { }
}
