using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Vector3`. Inherits from `AtomVariableInstancer&lt;Vector3Variable, Vector3Pair, Vector3, Vector3Event, Vector3PairEvent, Vector3Vector3Function&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Vector3 Variable Instancer")]
    public class Vector3VariableInstancer : AtomVariableInstancer<
        Vector3Variable,
        Vector3Pair,
        Vector3,
        Vector3Event,
        Vector3PairEvent,
        Vector3Vector3Function>
    { }
}
