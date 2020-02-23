using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `GameObject`. Inherits from `AtomValueList&lt;GameObject, GameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/GameObject", fileName = "GameObjectValueList")]
    public sealed class GameObjectValueList : AtomValueList<GameObject, GameObjectEvent> { }
}
