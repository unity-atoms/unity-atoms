using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalIntGameActionHelper : ConditionalGameActionHelper<int, IntAction, BoolIntFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Int/Conditional", fileName = "ConditionalIntAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalIntAction : IntAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalIntGameActionHelper _conditional = null;

        public override void Do(int t1)
        {
            _conditional.Do(t1);
        }
    }
}
