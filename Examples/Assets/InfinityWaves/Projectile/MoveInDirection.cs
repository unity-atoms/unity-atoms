using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveInDirection : MonoBehaviour
{
    public float Speed { set => _speed.Value = value; }

    [SerializeField]
    private FloatReference _speed;

    [SerializeField]
    private Vector2Reference _direction;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    void Update()
    {
        rb.velocity = _direction.Value.normalized * _speed.Value;
    }
}
