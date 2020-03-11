using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;

public class DestroyMe : MonoBehaviour
{
    [SerializeField]
    FloatReference _delay = new FloatReference(-1f);

    void Start()
    {
        Assert.IsNotNull(_delay);
        if (_delay.Value >= 0f)
        {
            Destroy(gameObject, _delay.Value);
        }
    }

    public void DestroyImmediate()
    {
        Destroy(gameObject);
    }
}
