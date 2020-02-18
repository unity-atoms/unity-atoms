using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `string`. Inherits from `AtomX2Listener&lt;string, StringStringAction, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer, StringStringEventReference, StringStringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String x 2 Listener")]
    public sealed class StringStringListener : AtomX2Listener<
        string,
        StringStringAction,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer,
        StringStringEventReference,
        StringStringUnityEvent>
    { }
}
