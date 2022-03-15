using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class ObjectFieldSubType : PropertyAttribute
{
    public Type SubType;

    public ObjectFieldSubType(Type subType)
    {
        SubType = subType;
    }
}
