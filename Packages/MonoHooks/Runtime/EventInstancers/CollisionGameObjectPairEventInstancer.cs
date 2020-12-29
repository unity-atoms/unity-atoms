using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `CollisionGameObjectPair`. Inherits from `AtomEventInstancer&lt;CollisionGameObjectPair, CollisionGameObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CollisionGameObjectPair Event Instancer")]
    public class CollisionGameObjectPairEventInstancer : AtomEventInstancer<CollisionGameObjectPair, CollisionGameObjectPairEvent> { }
}
