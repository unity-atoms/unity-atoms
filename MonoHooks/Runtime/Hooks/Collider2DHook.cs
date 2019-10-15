using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider2D`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class Collider2DHook : MonoHook<
        Collider2DEvent,
        Collider2DGameObjectEvent,
        Collider2D,
        GameObjectGameObjectFunction>
    { }
}
