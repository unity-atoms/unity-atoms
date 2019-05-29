using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/String")]
    public sealed class StringListener : GameEventListener<
        string,
        StringAction,
        StringEvent,
        UnityStringEvent>
    { }
}
