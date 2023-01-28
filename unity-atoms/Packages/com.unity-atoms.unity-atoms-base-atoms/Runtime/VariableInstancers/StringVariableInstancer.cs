using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `string`. Inherits from `AtomVariableInstancer&lt;StringVariable, StringPair, string, StringEvent, StringPairEvent, StringStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/String Variable Instancer")]
    public class StringVariableInstancer : AtomVariableInstancer<
        StringVariable,
        StringPair,
        string,
        StringEvent,
        StringPairEvent,
        StringStringFunction>
    { }
}
