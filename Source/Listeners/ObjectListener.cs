using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Object")]
    public sealed class ObjectListener : GameEventListener<
        object,
        ObjectAction,
        ObjectEvent,
        UnityObjectEvent>
    { }
}
