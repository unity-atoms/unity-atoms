using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `GameObject`. Inherits from `AtomBaseVariable&lt;GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/GameObject", fileName = "GameObjectConstant")]
    public sealed class GameObjectConstant : AtomBaseVariable<GameObject> { }
}
