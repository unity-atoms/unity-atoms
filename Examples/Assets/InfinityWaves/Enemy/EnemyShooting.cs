using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;
using UnityEngine;
using UnityAtoms.Tags;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;
    [SerializeField]
    private FiniteStateMachineReference _enemyState;
    [SerializeField]
    private GameObject _projectile;

    void Awake()
    {
        Transform target = null;
        AtomTags.OnInitialization(() => target = AtomTags.FindByTag(_tagToTarget.Value).transform);

        _enemyState.Machine.OnStateCooldown("ATTACKING", (value) =>
        {
            if (target)
            {
                var spawnPos = transform.position + transform.right;
                Instantiate(_projectile, spawnPos, transform.rotation);
            }
        }, gameObject);
    }
}
