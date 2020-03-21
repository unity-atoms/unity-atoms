using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Vector2`. Inherits from `AtomVariableInstancer&lt;Vector2Variable, Vector2Pair, Vector2, Vector2Event, Vector2PairEvent, Vector2Vector2Function&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Vector2 Variable Instancer")]
    public class Vector2VariableInstancer : AtomVariableInstancer<
        Vector2Variable,
        Vector2Pair,
        Vector2,
        Vector2Event,
        Vector2PairEvent,
        Vector2Vector2Function>
    { }
}
