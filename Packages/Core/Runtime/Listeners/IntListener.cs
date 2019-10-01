using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Int")]
    public sealed class IntListener : AtomListener<
        int,
        IntAction,
        IntEvent,
        IntUnityEvent>
    { }
}
