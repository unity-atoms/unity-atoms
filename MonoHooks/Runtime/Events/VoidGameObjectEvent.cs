using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event x 2 of type `Void` and `GameObject`. Inherits from `AtomEvent&lt;Void, GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void - GameObject", fileName = "VoidGameObjectEvent")]
    public sealed class VoidGameObjectEvent : AtomEvent<Void, GameObject> { }
}
