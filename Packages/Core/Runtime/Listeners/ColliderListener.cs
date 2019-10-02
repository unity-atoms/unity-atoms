using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider")]
    public sealed class ColliderListener : AtomListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        ColliderUnityEvent>
    { }
}
