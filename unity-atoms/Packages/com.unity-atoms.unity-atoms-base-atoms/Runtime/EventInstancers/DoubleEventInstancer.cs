using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `double`. Inherits from `AtomEventInstancer&lt;double, DoubleEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Double Event Instancer")]
    public class DoubleEventInstancer : AtomEventInstancer<double, DoubleEvent> { }
}
