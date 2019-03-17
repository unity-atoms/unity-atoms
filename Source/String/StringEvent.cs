using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/String/Event", fileName = "StringEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class StringEvent : GameEvent<string> { }
}