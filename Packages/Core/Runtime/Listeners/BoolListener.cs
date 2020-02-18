using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `bool`. Inherits from `AtomListener&lt;bool, BoolAction, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer, BoolEventReference, BoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool Listener")]
    public sealed class BoolListener : AtomListener<
        bool,
        BoolAction,
        BoolVariable,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer,
        BoolEventReference,
        BoolUnityEvent>
    { }
}
