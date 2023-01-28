using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Collider2D`. Inherits from `SetVariableValue&lt;Collider2D, Collider2DPair, Collider2DVariable, Collider2DConstant, Collider2DReference, Collider2DEvent, Collider2DPairEvent, Collider2DVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider2D", fileName = "SetCollider2DVariableValue")]
    public sealed class SetCollider2DVariableValue : SetVariableValue<
        Collider2D,
        Collider2DPair,
        Collider2DVariable,
        Collider2DConstant,
        Collider2DReference,
        Collider2DEvent,
        Collider2DPairEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer>
    { }
}
