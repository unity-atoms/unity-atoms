using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `ColliderGameObject`. Inherits from `UnityEvent&lt;ColliderGameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectUnityEvent : UnityEvent<ColliderGameObject> { }
}
