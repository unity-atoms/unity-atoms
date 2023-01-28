using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `string`. Inherits from `AtomEventInstancer&lt;string, StringEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/String Event Instancer")]
    public class StringEventInstancer : AtomEventInstancer<string, StringEvent> { }
}
