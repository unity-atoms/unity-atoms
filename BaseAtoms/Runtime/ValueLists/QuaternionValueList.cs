using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Quaternion`. Inherits from `AtomValueList&lt;Quaternion, QuaternionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Quaternion", fileName = "QuaternionValueList")]
    public sealed class QuaternionValueList : AtomValueList<Quaternion, QuaternionEvent> { }
}
