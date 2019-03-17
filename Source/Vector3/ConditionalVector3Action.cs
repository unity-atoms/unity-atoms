using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ConditionalVector3GameActionHelper : ConditionalGameActionHelper<Vector3, Vector3Action, BoolVector3Function> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Vector3/Conditional", fileName = "ConditionalVector3Action", order = CreateAssetMenuUtils.Order.CONDITIONAL)]
    public class ConditionalVector3Action : Vector3Action
    {
        [SerializeField]
        private ConditionalVector3GameActionHelper Conditional = null;

        public override void Do(Vector3 t1)
        {
            Conditional.Do(t1);
        }
    }
}
