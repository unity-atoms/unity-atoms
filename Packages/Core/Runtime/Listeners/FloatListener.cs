using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `float`. Inherits from `AtomListener&lt;float, FloatAction, FloatEvent, FloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float")]
    public sealed class FloatListener : AtomListener<
        float,
        FloatAction,
        FloatEvent,
        FloatUnityEvent>
    { }
}
