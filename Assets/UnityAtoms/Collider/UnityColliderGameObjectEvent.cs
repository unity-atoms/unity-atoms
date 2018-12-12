using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class UnityColliderGameObjectEvent : UnityEvent<Collider, GameObject> { }
}