using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `BoolPair`. Inherits from `AtomEvent&lt;BoolPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/BoolPair", fileName = "BoolPairEvent")]
    public sealed class BoolPairEvent : AtomEvent<BoolPair> { }
}
