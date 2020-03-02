using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Vector2`. Inherits from `AtomEventInstancer&lt;Vector2, Vector2Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector2 Event Instancer")]
    public class Vector2EventInstancer : AtomEventInstancer<Vector2, Vector2Event> { }
}
