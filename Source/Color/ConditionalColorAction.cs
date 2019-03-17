using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalColorGameActionHelper : ConditionalGameActionHelper<Color, ColorAction, BoolColorFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Color/Conditional", fileName = "ConditionalColorAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalColorAction : ColorAction
    {
        [SerializeField]
        private ConditionalColorGameActionHelper Conditional = null;

        public override void Do(Color t1)
        {
            Conditional.Do(t1);
        }
    }
}
