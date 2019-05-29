using UnityEngine;
namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Float")]
    public sealed class FloatListener : GameEventListener<
        float,
        FloatAction,
        FloatEvent,
        UnityFloatEvent>
    { }
}
