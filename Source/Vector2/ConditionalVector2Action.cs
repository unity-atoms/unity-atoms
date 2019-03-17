using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalVector2GameActionHelper : ConditionalGameActionHelper<Vector2, Vector2Action, BoolVector2Function> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Vector2/Conditional", fileName = "ConditionalVector2Action", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalVector2Action : Vector2Action
    {
        [SerializeField]
        private ConditionalVector2GameActionHelper Conditional = null;

        public override void Do(Vector2 t1)
        {
            Conditional.Do(t1);
        }
    }
}
