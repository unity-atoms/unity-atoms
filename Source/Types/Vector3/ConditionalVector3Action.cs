using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalVector3GameActionHelper : ConditionalGameActionHelper<Vector3, Vector3Action, BoolVector3Function> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Vector3/Conditional", fileName = "ConditionalVector3Action", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public sealed class ConditionalVector3Action : Vector3Action
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalVector3GameActionHelper _conditional = null;

        public override void Do(Vector3 t1)
        {
            _conditional.Do(t1);
        }
    }
}
