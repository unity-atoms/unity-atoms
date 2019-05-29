using System;
using UnityEngine;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public sealed class ConditionalTouchUserInputGameActionHelper : ConditionalGameActionHelper<TouchUserInput, TouchUserInputAction, BoolTouchUserInputFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Conditional Actions/TouchUserInput", fileName = "ConditionalTouchUserInputAction")]
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

