using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `int`. Inherits from `AtomEvent&lt;int&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Int", fileName = "IntEvent")]
    public sealed class IntEvent : AtomEvent<int> { }
}
