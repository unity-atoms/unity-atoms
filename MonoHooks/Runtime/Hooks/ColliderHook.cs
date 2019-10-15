using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class ColliderHook : MonoHook<
        ColliderEvent,
        ColliderGameObjectEvent,
        Collider,
        GameObjectGameObjectFunction>
    { }
}
