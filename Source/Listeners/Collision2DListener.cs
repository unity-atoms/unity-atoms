using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collision2D")]
    public sealed class Collision2DListener : GameEventListener<
        Collision2D,
        Collision2DAction,
        Collision2DEvent,
        UnityCollision2DEvent>
    { }
}
