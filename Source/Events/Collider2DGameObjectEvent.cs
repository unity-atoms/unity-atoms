using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D - GameObject", fileName = "Collider2DGameObjectEvent")]
    public sealed class Collider2DGameObjectEvent : GameEvent<Collider2D, GameObject> { }
}
