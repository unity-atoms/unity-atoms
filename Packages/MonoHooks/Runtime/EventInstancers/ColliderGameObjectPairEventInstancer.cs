using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `ColliderGameObjectPair`. Inherits from `AtomEventInstancer&lt;ColliderGameObjectPair, ColliderGameObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ColliderGameObjectPair Event Instancer")]
    public class ColliderGameObjectPairEventInstancer : AtomEventInstancer<ColliderGameObjectPair, ColliderGameObjectPairEvent> { }
}
