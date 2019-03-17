using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Event x 2", fileName = "BoolBoolEvent", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public class BoolBoolEvent : GameEvent<bool, bool> { }
}