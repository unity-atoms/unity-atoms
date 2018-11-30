using System;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/List", fileName = "GameObjectList", order = CreateAssetMenuUtils.Order.LIST)]
    public class GameObjectList : ScriptableObjectList<GameObject, GameObjectEvent> { }
}