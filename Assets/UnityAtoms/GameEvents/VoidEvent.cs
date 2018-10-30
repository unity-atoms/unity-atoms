using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Game Events/Void")]
    public class VoidEvent : GameEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }
}