using UnityEngine;
using UnityAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Void`. Inherits from `AtomListener&lt;Void, VoidAction, VoidEvent, VoidUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void Listener")]
    public sealed class VoidListener : AtomListener<
        Void,
        VoidAction,
        VoidEvent,
        VoidUnityEvent>
    { }
}
