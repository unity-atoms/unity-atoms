using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtoms.FSM;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Moves the Enemy based on the state of the enemy.
    /// </summary>
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
            Transform target = null;
            AtomTags.OnInitialization(() => target = AtomTags.FindByTag(_tagToTarget.Value).transform);
            var body = GetComponent<Rigidbody2D>();

            _enemyState.Machine.OnUpdate((deltaTime, value) =>
            {
                if (target)
                {
                    body.Move((target.position - transform.position), value == "CHASING" ? 2f : 0f, deltaTime);
                }
                else
                {
                    body.Move(Vector2.zero, 0f, deltaTime);
                }
            }, gameObject);
            _enemyState.Machine.DispatchWhen(command: "ATTACK", (value) => target != null && value == "CHASING" && (_shootingRange.Value >= Vector3.Distance(target.position, transform.position)), gameObject);
            _enemyState.Machine.DispatchWhen(command: "CHASE", (value) => target != null && value == "ATTACKING" && (_shootingRange.Value < Vector3.Distance(target.position, transform.position)), gameObject);
        }
    }
}