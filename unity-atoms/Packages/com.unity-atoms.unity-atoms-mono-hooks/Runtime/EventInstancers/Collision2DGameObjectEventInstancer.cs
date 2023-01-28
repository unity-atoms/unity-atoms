using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `Collision2DGameObject`. Inherits from `AtomEventInstancer&lt;Collision2DGameObject, Collision2DGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision2DGameObject Event Instancer")]
    public class Collision2DGameObjectEventInstancer : AtomEventInstancer<Collision2DGameObject, Collision2DGameObjectEvent> { }
}
