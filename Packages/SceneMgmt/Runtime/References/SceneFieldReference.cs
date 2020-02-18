using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Reference of type `SceneField`. Inherits from `AtomReference&lt;SceneField, SceneFieldConstant, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldReference : AtomReference<
        SceneField,
        SceneFieldConstant,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer> { }
}
