using UnityEngine;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Mobile/Touch User Input/Event", fileName = "TouchUserInputEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class TouchUserInputGameEvent : GameEvent<TouchUserInput> { }
}
