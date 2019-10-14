using UnityEngine;

namespace UnityAtoms
{
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
