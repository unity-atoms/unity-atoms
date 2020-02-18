using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `bool`. Inherits from `AtomX2Listener&lt;bool, BoolBoolAction, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer, BoolBoolEventReference, BoolBoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool x 2 Listener")]
    public sealed class BoolBoolListener : AtomX2Listener<
        bool,
        BoolBoolAction,
        BoolVariable,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer,
        BoolBoolEventReference,
        BoolBoolUnityEvent>
    { }
}
