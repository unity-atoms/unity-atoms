using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class UnityCollisionEvent : UnityEvent<Collision> { }
}
