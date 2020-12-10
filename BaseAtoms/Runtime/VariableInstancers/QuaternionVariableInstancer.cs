using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Quaternion`. Inherits from `AtomVariableInstancer&lt;QuaternionVariable, QuaternionPair, Quaternion, QuaternionEvent, QuaternionPairEvent, QuaternionQuaternionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Quaternion Variable Instancer")]
    public class QuaternionVariableInstancer : AtomVariableInstancer<
        QuaternionVariable,
        QuaternionPair,
        Quaternion,
        QuaternionEvent,
        QuaternionPairEvent,
        QuaternionQuaternionFunction>
    { }
}
