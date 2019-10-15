using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `float`. Inherits from `AtomEvent&lt;float, float&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Float x 2", fileName = "FloatFloatEvent")]
    public sealed class FloatFloatEvent : AtomEvent<float, float> { }
}
