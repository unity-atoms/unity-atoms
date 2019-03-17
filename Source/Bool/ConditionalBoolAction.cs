using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalBoolGameActionHelper : ConditionalGameActionHelper<bool, BoolAction, BoolBoolFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Conditional", fileName = "ConditionalBoolAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalBoolAction : BoolAction
    {
        [SerializeField]
        private ConditionalBoolGameActionHelper Conditional = null;

        public override void Do(bool t1)
        {
            Conditional.Do(t1);
        }
    }
}
