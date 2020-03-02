using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `int`. Inherits from `AtomEventInstancer&lt;int, IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Int Event Instancer")]
    public class IntEventInstancer : AtomEventInstancer<int, IntEvent> { }
}
