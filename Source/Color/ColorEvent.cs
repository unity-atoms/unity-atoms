using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Color/Event", fileName = "ColorEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class ColorEvent : GameEvent<Color> { }
}