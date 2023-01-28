using System;
using UnityEngine.Events;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// None generic Unity Event of type `SceneField`. Inherits from `UnityEvent&lt;SceneField&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldUnityEvent : UnityEvent<SceneField> { }
}
