using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;

public class DestroyMe : MonoBehaviour
{
    [SerializeField]
    FloatReference _delay;

    void Start()
    {
        Assert.IsNotNull(_delay);
        Destroy(gameObject, _delay.Value);
    }

    public void DestroyImmediate()
    {
        Destroy(gameObject);
    }
}
