using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `double`. Inherits from `AtomEvent&lt;double&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Double", fileName = "DoubleEvent")]
    public sealed class DoubleEvent : AtomEvent<double>
    {
    }
}
