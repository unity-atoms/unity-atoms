using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event x 2 of type `Collider2D` and `GameObject`. Inherits from `AtomEvent&lt;Collider2D, GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D - GameObject", fileName = "Collider2DGameObjectEvent")]
    public sealed class Collider2DGameObjectEvent : AtomEvent<Collider2D, GameObject> { }
}
