using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityAtoms.Tags;

public class DecreaseHealth : MonoBehaviour
{
    [SerializeField]
    private IntReference _decreaseBy;

    [SerializeField]
    private List<StringConstant> _tags;

    [SerializeField]
    private VoidEventReference _didCollide;

    void Start()
    {
        Assert.IsNotNull(_decreaseBy);
        Assert.IsNotNull(_tags);
        Assert.IsNotNull(_didCollide);
    }

    public void Do(Collider2D collider)
    {
        if (collider.gameObject.HasAnyTag(_tags))
        {
            collider.GetComponent<UnitHealth>().Health -= _decreaseBy;
        }
        _didCollide.Event.Raise();
    }
}
