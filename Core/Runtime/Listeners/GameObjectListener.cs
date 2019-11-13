using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `GameObject`. Inherits from `AtomListener&lt;GameObject, GameObjectAction, GameObjectEvent, GameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject Listener")]
    public sealed class GameObjectListener : AtomListener<
        GameObject,
        GameObjectAction,
        GameObjectEvent,
        GameObjectUnityEvent>
    { }
}
