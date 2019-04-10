using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalFloatGameActionHelper : ConditionalGameActionHelper<float, FloatAction, BoolFloatFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Float/Conditional", fileName = "ConditionalFloatAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalFloatAction : FloatAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalFloatGameActionHelper _conditional;

        public override void Do(float t1)
        {
            _conditional.Do(t1);
        }
    }
}
