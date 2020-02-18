using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Reference of type `SceneField`. Inherits from `AtomEventReference&lt;SceneField, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldEventReference : AtomEventReference<
        SceneField,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer> { }
}
