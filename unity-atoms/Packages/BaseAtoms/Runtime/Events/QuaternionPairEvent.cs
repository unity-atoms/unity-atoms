using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `QuaternionPair`. Inherits from `AtomEvent&lt;QuaternionPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/QuaternionPair", fileName = "QuaternionPairEvent")]
    public sealed class QuaternionPairEvent : AtomEvent<QuaternionPair>
    {
    }
}
