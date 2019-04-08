using UnityEngine;

namespace UnityAtoms
{
    public sealed class Collider2DListener : GameEventListener<
        Collider2D,
        Collider2DAction,
        Collider2DEvent,
        UnityCollider2DEvent>
    { }
}
