using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `bool`. Inherits from `AtomVariableInstancer&lt;BoolVariable, BoolPair, bool, BoolEvent, BoolPairEvent, BoolBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Bool Variable Instancer")]
    public class BoolVariableInstancer : AtomVariableInstancer<
        BoolVariable,
        BoolPair,
        bool,
        BoolEvent,
        BoolPairEvent,
        BoolBoolFunction>
    { }
}
