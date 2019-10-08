using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ColliderColliderUnityEvent : UnityEvent<Collider, Collider> { }
}
