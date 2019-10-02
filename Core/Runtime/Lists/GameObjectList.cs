using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject", fileName = "GameObjectList")]
    public sealed class GameObjectList : AtomList<GameObject, GameObjectEvent> { }
}
