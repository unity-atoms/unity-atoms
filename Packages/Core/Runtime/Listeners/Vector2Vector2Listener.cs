using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2 - Vector2")]
    public sealed class Vector2Vector2Listener : AtomListener<
        Vector2,
        Vector2,
        Vector2Vector2Action,
        Vector2Vector2Event,
        Vector2Vector2UnityEvent>
    { }
}
