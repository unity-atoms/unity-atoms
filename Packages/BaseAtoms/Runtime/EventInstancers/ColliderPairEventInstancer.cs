using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `ColliderPair`. Inherits from `AtomEventInstancer&lt;ColliderPair, ColliderPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ColliderPair Event Instancer")]
    public class ColliderPairEventInstancer : AtomEventInstancer<ColliderPair, ColliderPairEvent> { }
}
