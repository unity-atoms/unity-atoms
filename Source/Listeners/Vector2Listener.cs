using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Vector2")]
    public sealed class Vector2Listener : GameEventListener<
        Vector2,
        Vector2Action,
        Vector2Event,
        UnityVector2Event>
    { }
}
