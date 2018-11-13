using System;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject")]
    public class GameObjectList : ScriptableObjectList<GameObject, GameObjectEvent> { }
}