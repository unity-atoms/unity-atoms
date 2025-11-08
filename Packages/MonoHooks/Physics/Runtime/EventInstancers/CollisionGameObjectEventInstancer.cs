using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Instancer of type `CollisionGameObject`. Inherits from `AtomEventInstancer&lt;CollisionGameObject, CollisionGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CollisionGameObject Event Instancer")]
    public class CollisionGameObjectEventInstancer : AtomEventInstancer<CollisionGameObject, CollisionGameObjectEvent> { }
}
