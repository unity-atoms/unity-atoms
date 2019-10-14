using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Collider", fileName = "ColliderConstant")]
    public sealed class ColliderConstant : AtomBaseVariable<Collider> { }
}
