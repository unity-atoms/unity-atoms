using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject", fileName = "GameObjectList")]
    public sealed class GameObjectList : AtomList<GameObject, GameObjectEvent> { }
}
