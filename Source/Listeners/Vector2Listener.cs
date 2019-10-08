using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Vector2")]
    public sealed class Vector2Listener : AtomListener<
        Vector2,
        Vector2Action,
        Vector2Event,
        Vector2UnityEvent>
    { }
}
