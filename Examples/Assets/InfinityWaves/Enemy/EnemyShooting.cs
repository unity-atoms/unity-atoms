using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private FiniteStateMachineReference _enemyState;
    [SerializeField]
    private GameObject _projectile;

    void Awake()
    {
        _enemyState.Machine.OnStateCooldown("ATTACKING", (value) =>
        {
            var spawnPos = transform.position + transform.right;
            Instantiate(_projectile, spawnPos, transform.rotation);
        }, gameObject);
    }
}
