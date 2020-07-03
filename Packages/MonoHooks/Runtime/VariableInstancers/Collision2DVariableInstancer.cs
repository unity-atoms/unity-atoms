using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Collision2D`. Inherits from `AtomVariableInstancer&lt;Collision2DVariable, Collision2DPair, Collision2D, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collision2D Variable Instancer")]
    public class Collision2DVariableInstancer : AtomVariableInstancer<
        Collision2DVariable,
        Collision2DPair,
        Collision2D,
        Collision2DEvent,
        Collision2DPairEvent,
        Collision2DCollision2DFunction>
    { }
}
