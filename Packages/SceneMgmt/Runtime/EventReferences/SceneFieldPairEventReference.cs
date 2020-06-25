using System;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Reference of type `SceneFieldPair`. Inherits from `AtomEventReference&lt;SceneFieldPair, SceneFieldVariable, SceneFieldPairEvent, SceneFieldVariableInstancer, SceneFieldPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldPairEventReference : AtomEventReference<
        SceneFieldPair,
        SceneFieldVariable,
        SceneFieldPairEvent,
        SceneFieldVariableInstancer,
        SceneFieldPairEventInstancer>, IGetEvent 
    { }
}
