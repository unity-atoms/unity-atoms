using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D - GameObject")]
    public sealed class Collider2DGameObjectListener : GameEventListener<
        Collider2D,
        GameObject,
        Collider2DGameObjectAction,
        Collider2DGameObjectEvent,
        UnityCollider2DGameObjectEvent>
    { }
}
