using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Void", fileName = "VoidEvent")]
    public sealed class VoidEvent : GameEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }
}
