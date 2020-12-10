using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `double`. Inherits from `AtomVariableInstancer&lt;DoubleVariable, DoublePair, double, DoubleEvent, DoublePairEvent, DoubleDoubleFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Double Variable Instancer")]
    public class DoubleVariableInstancer : AtomVariableInstancer<
        DoubleVariable,
        DoublePair,
        double,
        DoubleEvent,
        DoublePairEvent,
        DoubleDoubleFunction>
    { }
}
