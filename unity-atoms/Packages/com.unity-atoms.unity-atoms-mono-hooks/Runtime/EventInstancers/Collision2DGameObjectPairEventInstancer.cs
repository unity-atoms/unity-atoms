using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `Collision2DGameObjectPair`. Inherits from `AtomEventInstancer&lt;Collision2DGameObjectPair, Collision2DGameObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision2DGameObjectPair Event Instancer")]
    public class Collision2DGameObjectPairEventInstancer : AtomEventInstancer<Collision2DGameObjectPair, Collision2DGameObjectPairEvent> { }
}
