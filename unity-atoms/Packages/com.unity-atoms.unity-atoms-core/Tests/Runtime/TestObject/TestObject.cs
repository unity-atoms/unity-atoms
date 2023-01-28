using System;

public class TestObject : IEquatable<TestObject>
{
    private object _object = new object();

    public bool Equals(TestObject other)
    {
        return _object.Equals(other._object);
    }
}