using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void", fileName = "VoidEvent")]
    public sealed class VoidEvent : AtomEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }
}
