using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event x 2 Reference of type `SceneField`. Inherits from `AtomEventX2Reference&lt;SceneField, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldSceneFieldEventReference : AtomEventX2Reference<
        SceneField,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer> { }
}
