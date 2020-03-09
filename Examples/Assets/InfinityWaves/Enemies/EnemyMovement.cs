using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtoms.FSM;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;

    [SerializeField]
    private FloatReference _shotRange = new FloatReference(5f);

    [SerializeField]
    private FloatReference _moveSpeedMultiplier = new FloatReference(2f);

    [SerializeField]
    private FiniteStateMachineReference _enemyMovement;


    void Awake()
    {
        var target = AtomTags.FindByTag(_tagToTarget.Value).transform;
        var body = GetComponent<Rigidbody2D>();

        _enemyMovement.Machine.OnUpdate((deltaTime, value) =>
        {
            // Calculate velocity
            var direction = (target.position - transform.position).normalized;
            var targetVelocity = value == "CHASING" ? new Vector2(direction.x, direction.y) * _moveSpeedMultiplier.Value : Vector2.zero;
            body.velocity = Vector2.Lerp(body.velocity, targetVelocity, 0.05f);

            // Calculate rotation
            float lookAtTargetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(lookAtTargetAngle, Vector3.forward);
        });
        _enemyMovement.Machine.DispatchWhen(command: "ATTACK", (value) => value == "CHASING" && (_shotRange.Value >= Vector3.Distance(target.position, transform.position)));
        _enemyMovement.Machine.DispatchWhen(command: "CHASE", (value) => value == "ATTACKING" && (_shotRange.Value < Vector3.Distance(target.position, transform.position)));
    }

    void Start()
    {
        _enemyMovement.Machine.Begin();
    }
}
