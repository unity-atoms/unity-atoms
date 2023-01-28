using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Vector3Pair`. Inherits from `AtomEvent&lt;Vector3Pair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3Pair", fileName = "Vector3PairEvent")]
    public sealed class Vector3PairEvent : AtomEvent<Vector3Pair>
    {
    }
}
