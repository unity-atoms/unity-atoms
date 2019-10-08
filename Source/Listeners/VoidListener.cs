using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Void")]
    public sealed class VoidListener : AtomListener<
        Void,
        VoidAction,
        VoidEvent,
        VoidUnityEvent>
    { }
}
