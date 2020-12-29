using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Collision2DPair`. Inherits from `AtomEvent&lt;Collision2DPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision2DPair", fileName = "Collision2DPairEvent")]
    public sealed class Collision2DPairEvent : AtomEvent<Collision2DPair>
    {
    }
}
