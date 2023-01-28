using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collision2D`. Inherits from `AtomEventInstancer&lt;Collision2D, Collision2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision2D Event Instancer")]
    public class Collision2DEventInstancer : AtomEventInstancer<Collision2D, Collision2DEvent> { }
}
