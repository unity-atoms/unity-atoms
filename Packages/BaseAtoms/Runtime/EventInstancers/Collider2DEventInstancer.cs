using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collider2D`. Inherits from `AtomEventInstancer&lt;Collider2D, Collider2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider2D Event Instancer")]
    public class Collider2DEventInstancer : AtomEventInstancer<Collider2D, Collider2DEvent> { }
}
