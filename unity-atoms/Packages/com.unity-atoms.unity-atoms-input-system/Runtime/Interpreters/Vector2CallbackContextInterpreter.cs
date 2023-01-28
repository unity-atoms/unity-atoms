using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.InputSystem
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Vector2")]
    public sealed class Vector2CallbackContextInterpreter : CallbackContextInterpreter<Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer>
    {
    }
}
