using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `string`. Inherits from `AtomListener&lt;string, StringAction, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer, StringEventReference, StringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String Listener")]
    public sealed class StringListener : AtomListener<
        string,
        StringAction,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer,
        StringEventReference,
        StringUnityEvent>
    { }
}
