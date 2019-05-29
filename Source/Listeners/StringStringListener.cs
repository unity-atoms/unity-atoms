using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/String - String")]
    public sealed class StringStringListener : GameEventListener<
        string,
        string,
        StringStringAction,
        StringStringEvent,
        UnityStringStringEvent>
    { }
}
