using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public class Collider2DGameObjectListener : GameEventListener<Collider2D, GameObject, Collider2DGameObjectAction, Collider2DGameObjectEvent, UnityCollider2DGameObjectEvent> { }
}
