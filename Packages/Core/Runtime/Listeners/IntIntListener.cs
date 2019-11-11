using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `int`. Inherits from `AtomListener&lt;int, int, IntIntAction, IntIntEvent, IntIntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int Int Listener")]
    public sealed class IntIntListener : AtomListener<
        int,
        int,
        IntIntAction,
        IntIntEvent,
        IntIntUnityEvent>
    { }
}
