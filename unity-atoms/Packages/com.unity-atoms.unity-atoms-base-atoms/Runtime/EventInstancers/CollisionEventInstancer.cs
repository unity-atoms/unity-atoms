using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collision`. Inherits from `AtomEventInstancer&lt;Collision, CollisionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision Event Instancer")]
    public class CollisionEventInstancer : AtomEventInstancer<Collision, CollisionEvent> { }
}
