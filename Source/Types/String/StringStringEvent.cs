using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/String/Event x 2", fileName = "StringStringEvent", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public sealed class StringStringEvent : GameEvent<string, string> { }
}
