using UnityEngine;
using UnityAtoms.FSM;

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
