using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Void/Event", fileName = "VoidEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class VoidEvent : GameEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }
}