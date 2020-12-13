using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Quaternion")]
    public sealed class QuaternionCallbackContextInterpreter : CallbackContextInterpreter<Quaternion, QuaternionPair, QuaternionConstant, QuaternionVariable, QuaternionEvent, QuaternionPairEvent, QuaternionQuaternionFunction, QuaternionVariableInstancer>
    {
    }
}
