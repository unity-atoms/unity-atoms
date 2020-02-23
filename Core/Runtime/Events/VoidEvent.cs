using UnityEngine;
using UnityAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Void`. Inherits from `AtomEvent&lt;Void&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void", fileName = "VoidEvent")]
    public sealed class VoidEvent : AtomEventBase
    {
        public void Raise()
        {
            RaiseNoValue();
        }
    }
}
