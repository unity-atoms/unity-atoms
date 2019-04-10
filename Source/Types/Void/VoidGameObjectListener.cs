using UnityEngine;

namespace UnityAtoms
{
    public sealed class VoidGameObjectListener : GameEventListener<
        Void,
        GameObject,
        VoidGameObjectAction,
        VoidGameObjectEvent,
        UnityVoidGameObjectEvent>
    { }
}
