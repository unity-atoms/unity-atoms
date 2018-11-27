using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/Void GameObject", fileName = "VoidGameObjectEvent",
        order                 = 101)]
    public class VoidGameObjectEvent : GameEvent<Void, GameObject>
    {
    }
}