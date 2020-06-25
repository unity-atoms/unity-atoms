using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `ColliderGameObject`. Inherits from `AtomEventInstancer&lt;ColliderGameObject, ColliderGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ColliderGameObject Event Instancer")]
    public class ColliderGameObjectEventInstancer : AtomEventInstancer<ColliderGameObject, ColliderGameObjectEvent> { }
}
