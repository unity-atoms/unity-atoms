using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject")]
    public sealed class GameObjectListener : AtomListener<
        GameObject,
        GameObjectAction,
        GameObjectEvent,
        GameObjectUnityEvent>
    { }
}
