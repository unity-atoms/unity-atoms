using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `Collider2DGameObject`. Inherits from `AtomEventInstancer&lt;Collider2DGameObject, Collider2DGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider2DGameObject Event Instancer")]
    public class Collider2DGameObjectEventInstancer : AtomEventInstancer<Collider2DGameObject, Collider2DGameObjectEvent> { }
}
