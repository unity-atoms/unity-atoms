using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `Collision2DGameObject`. Inherits from `AtomEvent&lt;Collision2DGameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision2DGameObject", fileName = "Collision2DGameObjectEvent")]
    public sealed class Collision2DGameObjectEvent : AtomEvent<Collision2DGameObject>
    {
    }
}
