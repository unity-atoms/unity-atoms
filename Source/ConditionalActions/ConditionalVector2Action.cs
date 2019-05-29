using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalVector2GameActionHelper : ConditionalGameActionHelper<Vector2, Vector2Action, BoolVector2Function> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Conditional Actions/Vector2", fileName = "ConditionalVector2Action")]
    public sealed class ConditionalVector2Action : Vector2Action
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalVector2GameActionHelper _conditional = null;

        public override void Do(Vector2 t1)
        {
            _conditional.Do(t1);
        }
    }
}
