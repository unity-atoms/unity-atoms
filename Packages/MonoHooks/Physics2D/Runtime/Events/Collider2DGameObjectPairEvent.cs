using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `Collider2DGameObjectPair`. Inherits from `AtomEvent&lt;Collider2DGameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2DGameObjectPair", fileName = "Collider2DGameObjectPairEvent")]
    public sealed class Collider2DGameObjectPairEvent : AtomEvent<Collider2DGameObjectPair>
    {
    }
}
