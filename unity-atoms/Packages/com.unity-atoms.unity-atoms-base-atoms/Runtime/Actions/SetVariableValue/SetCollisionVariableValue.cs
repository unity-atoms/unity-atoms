using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Collision`. Inherits from `SetVariableValue&lt;Collision, CollisionPair, CollisionVariable, CollisionConstant, CollisionReference, CollisionEvent, CollisionPairEvent, CollisionVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collision", fileName = "SetCollisionVariableValue")]
    public sealed class SetCollisionVariableValue : SetVariableValue<
        Collision,
        CollisionPair,
        CollisionVariable,
        CollisionConstant,
        CollisionReference,
        CollisionEvent,
        CollisionPairEvent,
        CollisionCollisionFunction,
        CollisionVariableInstancer>
    { }
}
