using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `int`. Inherits from `AtomListener&lt;int, IntAction, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer, IntEventReference, IntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int Listener")]
    public sealed class IntListener : AtomListener<
        int,
        IntAction,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer,
        IntEventReference,
        IntUnityEvent>
    { }
}
