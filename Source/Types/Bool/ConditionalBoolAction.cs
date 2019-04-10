using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalBoolGameActionHelper : ConditionalGameActionHelper<bool, BoolAction, BoolBoolFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Conditional", fileName = "ConditionalBoolAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalBoolAction : BoolAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalBoolGameActionHelper _conditional = null;

        public override void Do(bool t1)
        {
            _conditional.Do(t1);
        }
    }
}
