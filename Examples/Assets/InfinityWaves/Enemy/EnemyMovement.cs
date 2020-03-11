using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtoms.FSM;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;

    [SerializeField]
    private FloatReference _shootingRange = new FloatReference(5f);

    [SerializeField]
    private FloatReference _moveSpeedMultiplier = new FloatReference(2f);

    [SerializeField]
    private FiniteStateMachineReference _enemyState;


    void Awake()
    {
        var target = AtomTags.FindByTag(_tagToTarget.Value).transform;
        var body = GetComponent<Rigidbody2D>();

        _enemyState.Machine.OnUpdate((deltaTime, value) => body.Move((target.position - transform.position), value == "CHASING" ? 2f : 0f, deltaTime), gameObject);
        _enemyState.Machine.DispatchWhen(command: "ATTACK", (value) => value == "CHASING" && (_shootingRange.Value >= Vector3.Distance(target.position, transform.position)), gameObject);
        _enemyState.Machine.DispatchWhen(command: "CHASE", (value) => value == "ATTACKING" && (_shootingRange.Value < Vector3.Distance(target.position, transform.position)), gameObject);
    }

    // void Start()
    // {
    //     _enemyState.Machine.Begin();
    // }
}
