using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Vector3`. Inherits from `SetVariableValue&lt;Vector3, Vector3Pair, Vector3Variable, Vector3Constant, Vector3Reference, Vector3Event, Vector3PairEvent, Vector3VariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector3", fileName = "SetVector3VariableValue")]
    public sealed class SetVector3VariableValue : SetVariableValue<
        Vector3,
        Vector3Pair,
        Vector3Variable,
        Vector3Constant,
        Vector3Reference,
        Vector3Event,
        Vector3PairEvent,
        Vector3Vector3Function,
        Vector3VariableInstancer>
    { }
}
