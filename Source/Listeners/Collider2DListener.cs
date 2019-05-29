using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D")]
    public sealed class Collider2DListener : GameEventListener<
        Collider2D,
        Collider2DAction,
        Collider2DEvent,
        UnityCollider2DEvent>
    { }
}
