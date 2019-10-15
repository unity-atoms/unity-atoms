using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Action x 2 of type `Void` and `GameObject`. Inherits from `AtomAction&lt;Void, GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    public abstract class VoidGameObjectAction : AtomAction<Void, GameObject> { }
}
