using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Reference of type `SceneField`. Inherits from `EquatableAtomReference&lt;SceneField, SceneFieldPair, SceneFieldConstant, SceneFieldVariable, SceneFieldEvent, SceneFieldPairEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldReference : EquatableAtomReference<
        SceneField,
        SceneFieldPair,
        SceneFieldConstant,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldPairEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer>, IEquatable<SceneFieldReference>
    {
        public SceneFieldReference() : base() { }
        public SceneFieldReference(SceneField value) : base(value) { }
        public bool Equals(SceneFieldReference other) { return base.Equals(other); }
    }
}
