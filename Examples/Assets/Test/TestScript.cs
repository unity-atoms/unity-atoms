using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class TestScript : MonoBehaviour
{
    public IntReference reference;
    // public IntVariable test;
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    void Update()
    {
        // test.Value += 1;
        // var b = new IntPair() { Item1 = 1, Item2 = 2 };
        reference.Value = reference.Value + 1;
        // Debug.Log(reference.Value);
    }

    // public void UnityEventTester(int value)
    // {
    //     var a = value;
    //     Debug.Log(a);
    // }

    // public void UnityEventTester2(IntPair value)
    // {
    //     var a = value.Item1 + value.Item2;
    //     Debug.Log(a);
    // }
}
