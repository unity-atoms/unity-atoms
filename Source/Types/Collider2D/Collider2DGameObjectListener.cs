using UnityEngine;

namespace UnityAtoms
{
    public sealed class Collider2DGameObjectListener : GameEventListener<
        Collider2D,
        GameObject,
        Collider2DGameObjectAction,
        Collider2DGameObjectEvent,
        UnityCollider2DGameObjectEvent>
    { }
}
