using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `string`. Inherits from `AtomListener&lt;string, string, StringStringAction, StringStringEvent, StringStringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String String Listener")]
    public sealed class StringStringListener : AtomListener<
        string,
        string,
        StringStringAction,
        StringStringEvent,
        StringStringUnityEvent>
    { }
}
