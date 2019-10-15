using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `GameObject`. Inherits from `AtomListener&lt;GameObject, GameObject, GameObjectGameObjectAction, GameObjectGameObjectEvent, GameObjectGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject - GameObject")]
    public sealed class GameObjectGameObjectListener : AtomListener<
        GameObject,
        GameObject,
        GameObjectGameObjectAction,
        GameObjectGameObjectEvent,
        GameObjectGameObjectUnityEvent>
    { }
}
