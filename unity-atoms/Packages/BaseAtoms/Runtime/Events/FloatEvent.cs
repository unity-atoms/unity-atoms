using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `float`. Inherits from `AtomEvent&lt;float&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Float", fileName = "FloatEvent")]
    public sealed class FloatEvent : AtomEvent<float>
    {
    }
}
