using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class UnityVoidGameObjectEvent : UnityEvent<Void, GameObject> { }
}