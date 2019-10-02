using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Float x 2", fileName = "FloatFloatEvent")]
    public sealed class FloatFloatEvent : AtomEvent<float, float> { }
}
