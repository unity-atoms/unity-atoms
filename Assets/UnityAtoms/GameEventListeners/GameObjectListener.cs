using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class GameObjectListener : GameEventListener<GameObject, GameObjectAction, GameObjectEvent, UnityGameObjectEvent> { }
}
