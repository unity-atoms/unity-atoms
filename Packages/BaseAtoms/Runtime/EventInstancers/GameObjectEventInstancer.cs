using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `GameObject`. Inherits from `AtomEventInstancer&lt;GameObject, GameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/GameObject Event Instancer")]
    public class GameObjectEventInstancer : AtomEventInstancer<GameObject, GameObjectEvent> { }
}
