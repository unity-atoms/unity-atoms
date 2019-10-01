using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Int - Int")]
    public sealed class IntIntListener : AtomListener<
        int,
        int,
        IntIntAction,
        IntIntEvent,
        IntIntUnityEvent>
    { }
}
