using System;
using UnityEngine.Events;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// None generic Unity Event x 2 of type `SceneField`. Inherits from `UnityEvent&lt;SceneField, SceneField&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldSceneFieldUnityEvent : UnityEvent<SceneField, SceneField> { }
}
