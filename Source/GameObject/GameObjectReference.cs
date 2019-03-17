using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class GameObjectReference : ScriptableObjectReference<GameObject, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent> { }
}