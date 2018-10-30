using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class Collider2DListener : GameEventListener<Collider2D, Collider2DAction, Collider2DEvent, UnityCollider2DEvent> { }
}
