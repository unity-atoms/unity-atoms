using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public sealed class ConditionalVoidGameActionHelper : ConditionalGameActionHelper<Void, VoidAction, BoolVoidFunction> { }

    [CreateAssetMenu(menuName = "Unity Atoms/Conditional Actions/Void", fileName = "ConditionalVoidAction")]
    public sealed class ConditionalVoidAction : VoidAction
    {
        [FormerlySerializedAs("Conditional")]
        [SerializeField]
        private ConditionalVoidGameActionHelper _conditional = null;

        public override void Do()
        {
            _conditional.Do(new Void());
        }
    }
}
