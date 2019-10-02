using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float")]
    public sealed class FloatListener : AtomListener<
        float,
        FloatAction,
        FloatEvent,
        FloatUnityEvent>
    { }
}
