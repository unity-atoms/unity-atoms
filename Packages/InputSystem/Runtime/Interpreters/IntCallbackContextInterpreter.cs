using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Int")]
    public sealed class IntCallbackContextInterpreter : CallbackContextInterpreter<int, Pair<int>, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer>
    {
    }
}
