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
    private FiniteStateMachineReference _enemyStateMachineRef;

    private Transform _target;

    void Start()
    {
        _target = AtomTags.FindByTag(_tagToTarget.Value).transform;
        _enemyStateMachineRef.Machine.Begin();
    }

    void Update()
    {
        var inRange = _shotRange.Value >= Vector3.Distance(_target.position, transform.position);
        if (_enemyStateMachineRef.Machine.Value != "ATTACKING" && inRange)
        {
            _enemyStateMachineRef.Machine.Dispatch("ATTACK");
        }
        else if (_enemyStateMachineRef.Machine.Value != "CHASING" && !inRange)
        {
            _enemyStateMachineRef.Machine.Dispatch("CHASE");
        }


        var direction = _target.position - transform.position;
        if (_enemyStateMachineRef.Machine.Value == "CHASING")
        {
            GetComponent<Rigidbody2D>().velocity = direction.normalized * 5f;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
