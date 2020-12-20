using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject", fileName = "GameObjectList")]
    public sealed class GameObjectList : AtomList<GameObject, GameObjectEvent> { }
}
