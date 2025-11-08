using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityEngine.Collision`. Inherits from `AtomVariableInstancer&lt;CollisionVariable, CollisionPair, UnityEngine.Collision, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collision Variable Instancer")]
    public class CollisionVariableInstancer : AtomVariableInstancer<
        CollisionVariable,
        CollisionPair,
        UnityEngine.Collision,
        CollisionEvent,
        CollisionPairEvent,
        CollisionCollisionFunction>
    { }
}
