using System;
using UnityEngine;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public sealed class ConditionalTouchUserInputGameActionHelper : ConditionalGameActionHelper<TouchUserInput, TouchUserInputAction, BoolTouchUserInputFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Mobile/Touch User Input/Conditional", fileName = "ConditionalTouchUserInputAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalTouchUserInputAction : TouchUserInputAction
    {
        [SerializeField]
        public ConditionalTouchUserInputGameActionHelper Conditional;

        public override void Do(TouchUserInput t1)
        {
            Conditional.Do(t1);
        }
    }
}

