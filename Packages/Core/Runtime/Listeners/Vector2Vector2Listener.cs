using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Vector2`. Inherits from `AtomX2Listener&lt;Vector2, Vector2Vector2Action, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer, Vector2Vector2EventReference, Vector2Vector2UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2 x 2 Listener")]
    public sealed class Vector2Vector2Listener : AtomX2Listener<
        Vector2,
        Vector2Vector2Action,
        Vector2Variable,
        Vector2Event,
        Vector2Vector2Event,
        Vector2Vector2Function,
        Vector2VariableInstancer,
        Vector2Vector2EventReference,
        Vector2Vector2UnityEvent>
    { }
}
