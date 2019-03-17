using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalVoidGameActionHelper : ConditionalGameActionHelper<Void, VoidAction, BoolVoidFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Void/Conditional", fileName = "ConditionalVoidAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalVoidAction : VoidAction
    {
        [SerializeField]
        private ConditionalVoidGameActionHelper Conditional = null;

        public override void Do()
        {
            Conditional.Do(new Void());
        }
    }
}
