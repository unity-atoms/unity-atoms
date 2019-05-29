using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalColorGameActionHelper : ConditionalGameActionHelper<Color, ColorAction, BoolColorFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Conditional Actions/Color", fileName = "ConditionalColorAction")]
    public sealed class ConditionalColorAction : ColorAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalColorGameActionHelper _conditional = null;

        public override void Do(Color t1)
        {
            _conditional.Do(t1);
        }
    }
}
