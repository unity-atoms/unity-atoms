using UnityEngine;

namespace UnityAtoms.BaseAtom
{
    /// <summary>
    /// Event Instancer of type `CollisionPair`. Inherits from `AtomEventInstancer&lt;CollisionPair, CollisionPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CollisionPair Event Instancer")]
    public class CollisionPairEventInstancer : AtomEventInstancer<CollisionPair, CollisionPairEvent> { }
}
