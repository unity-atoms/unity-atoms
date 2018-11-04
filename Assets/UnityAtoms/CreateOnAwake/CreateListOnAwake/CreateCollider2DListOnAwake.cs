
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.Utils;

namespace UnityAtoms
{
    public class CreateCollider2DListOnAwake : CreateListOnAwake<Collider2D, Collider2DList, Collider2DEvent, Collider2DListener, Collider2DAction, Collider2DListAction, Collider2DListGameObjectAction, UnityCollider2DEvent> { }
}