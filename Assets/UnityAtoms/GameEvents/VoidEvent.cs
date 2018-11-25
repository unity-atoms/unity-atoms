using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/Void", fileName = "VoidEvent", order = 100)]
    public class VoidEvent : GameEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }
}