using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector2", fileName = "Vector2Variable")]
    public sealed class Vector2Variable : EquatableScriptableObjectVariable<Vector2, Vector2Event, Vector2Vector2Event> { }
}
