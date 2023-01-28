using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Quaternion`. Inherits from `AtomEvent&lt;Quaternion&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Quaternion", fileName = "QuaternionEvent")]
    public sealed class QuaternionEvent : AtomEvent<Quaternion>
    {
    }
}
