using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `Collider2DGameObjectPair`. Inherits from `AtomEventInstancer&lt;Collider2DGameObjectPair, Collider2DGameObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider2DGameObjectPair Event Instancer")]
    public class Collider2DGameObjectPairEventInstancer : AtomEventInstancer<Collider2DGameObjectPair, Collider2DGameObjectPairEvent> { }
}
