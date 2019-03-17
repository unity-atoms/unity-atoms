using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class UnityCollider2DGameObjectEvent : UnityEvent<Collider2D, GameObject> { }
}