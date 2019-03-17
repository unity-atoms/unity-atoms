using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalIntGameActionHelper : ConditionalGameActionHelper<int, IntAction, BoolIntFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Int/Conditional", fileName = "ConditionalIntAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalIntAction : IntAction
    {
        [SerializeField]
        private ConditionalIntGameActionHelper Conditional = null;

        public override void Do(int t1)
        {
            Conditional.Do(t1);
        }
    }
}
