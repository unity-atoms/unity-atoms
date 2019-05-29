using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Int")]
    public sealed class IntListener : GameEventListener<int, IntAction, IntEvent, UnityIntEvent> { }
}
