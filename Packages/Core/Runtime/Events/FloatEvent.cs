using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Float", fileName = "FloatEvent")]
    public sealed class FloatEvent : AtomEvent<float> { }
}
