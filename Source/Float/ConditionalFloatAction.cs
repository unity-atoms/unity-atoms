using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalFloatGameActionHelper : ConditionalGameActionHelper<float, FloatAction, BoolFloatFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Float/Conditional", fileName = "ConditionalFloatAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalFloatAction : FloatAction
    {
        [SerializeField]
        private ConditionalFloatGameActionHelper Conditional = null;

        public override void Do(float t1)
        {
            Conditional.Do(t1);
        }
    }
}
