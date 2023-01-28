using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Quaternion`. Inherits from `EquatableAtomVariable&lt;Quaternion, QuaternionPair, QuaternionEvent, QuaternionPairEvent, QuaternionQuaternionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Quaternion", fileName = "QuaternionVariable")]
    public sealed class QuaternionVariable : EquatableAtomVariable<Quaternion, QuaternionPair, QuaternionEvent, QuaternionPairEvent, QuaternionQuaternionFunction>
    {
    }
}
