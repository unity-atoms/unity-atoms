using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Reference of type `SceneField`. Inherits from `AtomReference&lt;SceneField, SceneFieldVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldReference : AtomReference<
        SceneField,
        SceneFieldVariable> { }
}
