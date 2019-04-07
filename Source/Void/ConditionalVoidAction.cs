using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalVoidGameActionHelper : ConditionalGameActionHelper<Void, VoidAction, BoolVoidFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Void/Conditional", fileName = "ConditionalVoidAction", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalVoidAction : VoidAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalVoidGameActionHelper _conditional;

        public override void Do()
        {
            _conditional.Do(new Void());
        }
    }
}
