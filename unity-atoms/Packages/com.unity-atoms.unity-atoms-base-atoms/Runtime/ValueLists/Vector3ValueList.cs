using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Vector3`. Inherits from `AtomValueList&lt;Vector3, Vector3Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Vector3", fileName = "Vector3ValueList")]
    public sealed class Vector3ValueList : AtomValueList<Vector3, Vector3Event> { }
}
