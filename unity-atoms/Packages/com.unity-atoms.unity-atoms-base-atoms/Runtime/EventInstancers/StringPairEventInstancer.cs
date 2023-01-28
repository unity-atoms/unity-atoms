using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `StringPair`. Inherits from `AtomEventInstancer&lt;StringPair, StringPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/StringPair Event Instancer")]
    public class StringPairEventInstancer : AtomEventInstancer<StringPair, StringPairEvent> { }
}
