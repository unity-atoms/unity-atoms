using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider")]
    public sealed class ColliderListener : AtomListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        ColliderUnityEvent>
    { }
}
