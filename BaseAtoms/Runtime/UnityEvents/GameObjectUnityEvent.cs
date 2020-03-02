using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `GameObject`. Inherits from `UnityEvent&lt;GameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectUnityEvent : UnityEvent<GameObject> { }
}
