using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class UnityCollision2DEvent : UnityEvent<Collision2D> { }
}
