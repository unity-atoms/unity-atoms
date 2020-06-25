using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `Collider2DGameObject`. Inherits from `AtomEvent&lt;Collider2DGameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2DGameObject", fileName = "Collider2DGameObjectEvent")]
    public sealed class Collider2DGameObjectEvent : AtomEvent<Collider2DGameObject> { }
}
