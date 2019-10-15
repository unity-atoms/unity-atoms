namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Void`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class VoidHook : MonoHook<
        VoidEvent,
        VoidGameObjectEvent,
        Void,
        GameObjectGameObjectFunction>
    { }
}
