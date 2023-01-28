using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Vector3")]
    public sealed class Vector3CallbackContextInterpreter : CallbackContextInterpreter<Vector3, Vector3Pair, Vector3Constant, Vector3Variable, Vector3Event, Vector3PairEvent, Vector3Vector3Function, Vector3VariableInstancer>
    {
    }
}
