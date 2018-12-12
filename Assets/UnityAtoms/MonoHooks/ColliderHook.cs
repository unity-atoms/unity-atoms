using UnityEngine;

namespace UnityAtoms
{
    public abstract class ColliderHook : MonoHook<ColliderEvent, ColliderGameObjectEvent, Collider, GameObjectGameObjectFunction> { }
}