using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `string`. Inherits from `AtomVariableInstancer&lt;StringVariable, string, StringEvent, StringStringEvent, StringStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/String Instancer")]
    public class StringVariableInstancer : AtomVariableInstancer<StringVariable, string, StringEvent, StringStringEvent, StringStringFunction> { }
}
