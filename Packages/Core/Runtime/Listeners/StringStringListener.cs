using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/String - String")]
    public sealed class StringStringListener : AtomListener<
        string,
        string,
        StringStringAction,
        StringStringEvent,
        StringStringUnityEvent>
    { }
}
