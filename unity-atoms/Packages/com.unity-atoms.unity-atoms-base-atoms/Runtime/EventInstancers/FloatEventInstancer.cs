using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `float`. Inherits from `AtomEventInstancer&lt;float, FloatEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Float Event Instancer")]
    public class FloatEventInstancer : AtomEventInstancer<float, FloatEvent> { }
}
