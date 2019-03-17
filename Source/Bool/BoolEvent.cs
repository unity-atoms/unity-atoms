using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Event", fileName = "BoolEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class BoolEvent : GameEvent<bool> { }
}