using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `GameObject`. Inherits from `AtomListener&lt;GameObject, GameObjectAction, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer, GameObjectEventReference, GameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject Listener")]
    public sealed class GameObjectListener : AtomListener<
        GameObject,
        GameObjectAction,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer,
        GameObjectEventReference,
        GameObjectUnityEvent>
    { }
}
