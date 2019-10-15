using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Void` and `GameObject`. Inherits from `UnityEvent&lt;Void, GameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class VoidGameObjectUnityEvent : UnityEvent<Void, GameObject> { }
}
