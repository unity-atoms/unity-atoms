using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Collision2D`. Inherits from `SetVariableValue&lt;Collision2D, Collision2DPair, Collision2DVariable, Collision2DConstant, Collision2DReference, Collision2DEvent, Collision2DPairEvent, Collision2DVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collision2D", fileName = "SetCollision2DVariableValue")]
    public sealed class SetCollision2DVariableValue : SetVariableValue<
        Collision2D,
        Collision2DPair,
        Collision2DVariable,
        Collision2DConstant,
        Collision2DReference,
        Collision2DEvent,
        Collision2DPairEvent,
        Collision2DCollision2DFunction,
        Collision2DVariableInstancer>
    { }
}
