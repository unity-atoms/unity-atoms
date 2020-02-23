using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Reference of type `SceneField`. Inherits from `EquatableAtomReference&lt;SceneField, SceneFieldConstant, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldReference : EquatableAtomReference<
        SceneField,
        SceneFieldConstant,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer>, IEquatable<SceneFieldReference>
    {
        public SceneFieldReference() : base() { }
        public SceneFieldReference(SceneField value) : base(value) { }
        public bool Equals(SceneFieldReference other) { return base.Equals(other); }
    }
}
