using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Collider2DPair`. Inherits from `AtomEvent&lt;Collider2DPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2DPair", fileName = "Collider2DPairEvent")]
    public sealed class Collider2DPairEvent : AtomEvent<Collider2DPair> { }
}
