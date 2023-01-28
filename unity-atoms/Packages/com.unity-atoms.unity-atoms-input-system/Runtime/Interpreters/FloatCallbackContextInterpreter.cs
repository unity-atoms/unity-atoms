using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Float")]
    public sealed class FloatCallbackContextInterpreter : CallbackContextInterpreter<float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer>
    {
    }
}
