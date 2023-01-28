using NUnit.Framework;
using UnityAtoms;
using System.Linq;
using NSubstitute;
using System;

public class AtomBaseVariableTests
{
    [Test]
    public void Has_EditorIcon_attribute()
    {
        var _attribute = typeof(AtomBaseVariable).GetCustomAttributes(typeof(EditorIcon), true).FirstOrDefault() as EditorIcon;

        Assert.NotNull(_attribute);
    }

    [Test]
    public void Can_be_equated()
    {
        var a = Substitute.For<AtomBaseVariable<dynamic>>();
        var b = Substitute.For<AtomBaseVariable<dynamic>>();

        Assert.True(a.Equals(a));
        Assert.False(a.Equals(b));
    }
}