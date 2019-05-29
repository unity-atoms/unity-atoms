using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Void - GameObject")]
    public sealed class VoidGameObjectListener : GameEventListener<
        Void,
        GameObject,
        VoidGameObjectAction,
        VoidGameObjectEvent,
        UnityVoidGameObjectEvent>
    { }
}
