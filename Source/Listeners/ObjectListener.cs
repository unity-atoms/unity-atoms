using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Object")]
    public sealed class ObjectListener : AtomListener<
        object,
        ObjectAction,
        ObjectEvent,
        UnityObjectEvent>
    { }
}
