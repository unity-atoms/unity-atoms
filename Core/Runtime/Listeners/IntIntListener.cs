using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `int`. Inherits from `AtomX2Listener&lt;int, IntIntAction, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer, IntIntEventReference, IntIntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int x 2 Listener")]
    public sealed class IntIntListener : AtomX2Listener<
        int,
        IntIntAction,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer,
        IntIntEventReference,
        IntIntUnityEvent>
    { }
}
