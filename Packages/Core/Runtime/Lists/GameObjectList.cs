using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `GameObject`. Inherits from `AtomList&lt;GameObject, GameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject", fileName = "GameObjectList")]
    public sealed class GameObjectList : AtomList<GameObject, GameObjectEvent> { }
}
