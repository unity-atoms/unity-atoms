
using UnityEngine;

namespace UnityAtoms
{
    public class CreateCollider2DEventOnAwake : CreateEventOnAwake<
        Collider2D, Collider2DEvent, Collider2DGameObjectEvent,
        Collider2DListener, Collider2DGameObjectListener,
        Collider2DAction, Collider2DGameObjectAction,
        UnityCollider2DEvent, UnityCollider2DGameObjectEvent,
        Collider2DHook
        >
    { }
}