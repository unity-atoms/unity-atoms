using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/GameObject", fileName = "GameObjectConstant")]
    public sealed class GameObjectConstant : AtomBaseVariable<GameObject> { }
}
