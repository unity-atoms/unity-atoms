using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject")]
    public sealed class GameObjectListener : AtomListener<
        GameObject,
        GameObjectAction,
        GameObjectEvent,
        GameObjectUnityEvent>
    { }
}
