using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `Collision2DGameObjectPair`. Inherits from `AtomEvent&lt;Collision2DGameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision2DGameObjectPair", fileName = "Collision2DGameObjectPairEvent")]
    public sealed class Collision2DGameObjectPairEvent : AtomEvent<Collision2DGameObjectPair>
    {
    }
}
