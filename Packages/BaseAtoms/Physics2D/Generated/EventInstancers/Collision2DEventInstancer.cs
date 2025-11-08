using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UnityEngine.Collision2D`. Inherits from `AtomEventInstancer&lt;UnityEngine.Collision2D, Collision2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision2D Event Instancer")]
    public class Collision2DEventInstancer : AtomEventInstancer<UnityEngine.Collision2D, Collision2DEvent> { }
}
