using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void - GameObject", fileName = "VoidGameObjectEvent")]
    public sealed class VoidGameObjectEvent : GameEvent<Void, GameObject> { }
}
