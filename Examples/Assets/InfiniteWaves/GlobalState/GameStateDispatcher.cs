using UnityEngine;
using UnityAtoms.FSM;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Dispatches commands to the FSM.
    /// </summary>
    public class GameStateDispatcher : MonoBehaviour
    {
        [SerializeField]
        private FiniteStateMachineReference _gameStateRef;

        public void DispatchGameOverIfDead(int health)
        {
            if (health <= 0)
            {
                _gameStateRef.Machine.Dispatch("SetGameOver");
            }
        }
    }
}