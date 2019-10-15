using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `int`. Inherits from `AtomEvent&lt;int, int&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Int x 2", fileName = "IntIntEvent")]
    public sealed class IntIntEvent : AtomEvent<int, int> { }
}
