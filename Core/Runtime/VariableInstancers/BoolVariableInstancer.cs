using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `bool`. Inherits from `AtomVariableInstancer&lt;BoolVariable, bool, BoolEvent, BoolBoolEvent, BoolBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Bool Instancer")]
    public class BoolVariableInstancer : AtomVariableInstancer<BoolVariable, bool, BoolEvent, BoolBoolEvent, BoolBoolFunction> { }
}
