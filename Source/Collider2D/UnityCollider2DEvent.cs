using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class UnityCollider2DEvent : UnityEvent<Collider2D> { }
}
