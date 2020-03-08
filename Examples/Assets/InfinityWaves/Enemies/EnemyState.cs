using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtoms.FSM;

public class EnemyState : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;

    [SerializeField]
    private FloatReference _shotRange = new FloatReference(5f);

    [SerializeField]
    private FiniteStateMachine _enemtStateMachine;

    private Transform _target;

    void Start()
    {
        _enemtStateMachine.Begin();
    }

    void Update()
    {
        if (_enemtStateMachine.Value != "ATTACKING" && _shotRange.Value >= Vector3.Distance(_target.position, transform.position))
        {
            _enemtStateMachine.Dispatch("ATTACK");
        }
        else
        {
            _enemtStateMachine.Dispatch("CHASE");
        }
    }
}
