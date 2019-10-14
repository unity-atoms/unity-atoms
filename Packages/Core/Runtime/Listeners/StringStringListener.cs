using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String - String")]
    public sealed class StringStringListener : AtomListener<
        string,
        string,
        StringStringAction,
        StringStringEvent,
        StringStringUnityEvent>
    { }
}
