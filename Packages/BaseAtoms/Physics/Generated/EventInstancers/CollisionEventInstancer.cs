using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UnityEngine.Collision`. Inherits from `AtomEventInstancer&lt;UnityEngine.Collision, CollisionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision Event Instancer")]
    public class CollisionEventInstancer : AtomEventInstancer<UnityEngine.Collision, CollisionEvent> { }
}
