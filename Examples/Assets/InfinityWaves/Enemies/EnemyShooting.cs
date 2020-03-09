using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private StringReference _tagToTarget;
    [SerializeField]
    private FloatReference _shotRange = new FloatReference(5f);

    [SerializeField]
    private FiniteStateMachineReference _enemyMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
