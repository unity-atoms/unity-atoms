using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Void")]
    public sealed class VoidListener : GameEventListener<
        Void,
        VoidAction,
        VoidEvent,
        UnityVoidEvent>
    { }
}
