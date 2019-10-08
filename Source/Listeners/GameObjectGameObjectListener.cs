using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/GameObject - GameObject")]
    public sealed class GameObjectGameObjectListener : AtomListener<
        GameObject,
        GameObject,
        GameObjectGameObjectAction,
        GameObjectGameObjectEvent,
        GameObjectGameObjectUnityEvent>
    { }
}
