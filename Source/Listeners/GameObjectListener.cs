using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/GameObject")]
    public sealed class GameObjectListener : GameEventListener<
        GameObject,
        GameObjectAction,
        GameObjectEvent,
        UnityGameObjectEvent>
    { }
}
