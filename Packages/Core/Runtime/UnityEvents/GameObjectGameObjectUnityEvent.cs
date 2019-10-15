using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `GameObject`. Inherits from `UnityEvent&lt;GameObject, GameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectGameObjectUnityEvent : UnityEvent<GameObject, GameObject> { }
}
