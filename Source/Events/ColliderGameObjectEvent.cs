using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider - GameObject", fileName = "ColliderGameObjectEvent")]
    public sealed class ColliderGameObjectEvent : GameEvent<Collider, GameObject> { }
}
