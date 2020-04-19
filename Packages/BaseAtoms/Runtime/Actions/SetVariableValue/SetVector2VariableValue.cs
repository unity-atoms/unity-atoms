using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Vector2`. Inherits from `SetVariableValue&lt;Vector2, Vector2Pair, Vector2Variable, Vector2Constant, Vector2Reference, Vector2Event, Vector2PairEvent, Vector2VariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector2", fileName = "SetVector2VariableValue")]
    public sealed class SetVector2VariableValue : SetVariableValue<
        Vector2,
        Vector2Pair,
        Vector2Variable,
        Vector2Constant,
        Vector2Reference,
        Vector2Event,
        Vector2PairEvent,
        Vector2Vector2Function,
        Vector2VariableInstancer>
    { }
}
