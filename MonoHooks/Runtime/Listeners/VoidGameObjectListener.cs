using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Listener x 2 of type `Void` and `GameObject`. Inherits from `AtomListener&lt;Void, GameObject, VoidGameObjectAction, VoidGameObjectEvent, VoidGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void GameObject Listener")]
    public sealed class VoidGameObjectListener : AtomListener<
        Void,
        GameObject,
        VoidGameObjectAction,
        VoidGameObjectEvent,
        VoidGameObjectUnityEvent>
    { }
}
