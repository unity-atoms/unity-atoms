using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String - String")]
    public sealed class StringStringListener : AtomListener<
        string,
        string,
        StringStringAction,
        StringStringEvent,
        StringStringUnityEvent>
    { }
}
