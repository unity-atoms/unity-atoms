using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collider`. Inherits from `AtomEventInstancer&lt;Collider, ColliderEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider Event Instancer")]
    public class ColliderEventInstancer : AtomEventInstancer<Collider, ColliderEvent> { }
}
