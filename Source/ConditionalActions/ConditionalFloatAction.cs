using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalFloatGameActionHelper : ConditionalGameActionHelper<float, FloatAction, BoolFloatFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Conditional Actions/Float", fileName = "ConditionalFloatAction")]
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
