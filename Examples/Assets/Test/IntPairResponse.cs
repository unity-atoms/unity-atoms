using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;


[CreateAssetMenu(menuName = "Unity Atoms/IntPairResponse", fileName = "IntPairResponse")]
public class IntPairResponse : IntPairAction
{
    public override void Do(IntPair value)
    {
        var a = value;
        // Debug.Log(value.Item1 + ", " + value.Item2);
    }
}
