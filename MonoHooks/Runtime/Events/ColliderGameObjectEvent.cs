using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event x 2 of type `Collider` and `GameObject`. Inherits from `AtomEvent&lt;Collider, GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider - GameObject", fileName = "ColliderGameObjectEvent")]
    public sealed class ColliderGameObjectEvent : AtomEvent<Collider, GameObject> { }
}
