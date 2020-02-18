using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `GameObject`. Inherits from `AtomX2Listener&lt;GameObject, GameObjectGameObjectAction, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer, GameObjectGameObjectEventReference, GameObjectGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject x 2 Listener")]
    public sealed class GameObjectGameObjectListener : AtomX2Listener<
        GameObject,
        GameObjectGameObjectAction,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer,
        GameObjectGameObjectEventReference,
        GameObjectGameObjectUnityEvent>
    { }
}
