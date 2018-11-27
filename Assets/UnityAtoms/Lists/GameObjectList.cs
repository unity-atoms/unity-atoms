using System;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/GameObject", fileName = "GameObjectList", order = 7)]
    public class GameObjectList : ScriptableObjectList<GameObject, GameObjectEvent>
    {
    }
}