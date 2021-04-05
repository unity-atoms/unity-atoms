using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Double")]
    public sealed class DoubleCallbackContextInterpreter : CallbackContextInterpreter<double, Pair<double>, DoubleConstant, DoubleVariable, DoubleEvent, DoublePairEvent, DoubleDoubleFunction, DoubleVariableInstancer>
    {
    }
}
