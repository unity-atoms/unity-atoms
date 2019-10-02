using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int")]
    public sealed class IntListener : AtomListener<
        int,
        IntAction,
        IntEvent,
        IntUnityEvent>
    { }
}
