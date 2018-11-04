using System;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/GameObject")]
    public class GameObjectList : ScriptableObjectList<GameObject, GameObjectEvent> { }
}