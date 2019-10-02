using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D")]
    public sealed class Collider2DListener : AtomListener<
        Collider2D,
        Collider2DAction,
        Collider2DEvent,
        Collider2DUnityEvent>
    { }
}
