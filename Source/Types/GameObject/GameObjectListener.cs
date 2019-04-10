using UnityEngine;

namespace UnityAtoms
{
    public sealed class GameObjectListener : GameEventListener<
        GameObject,
        GameObjectAction,
        GameObjectEvent,
        UnityGameObjectEvent>
    { }
}
