using NUnit.Framework;
using UnityAtoms;
using FluentAssertions;
using NSubstitute;

public class AtomBaseVariableTests
{
    [Test]
    public void Has_EditorIcon_attribute()
    {
        typeof(AtomBaseVariable).Should().BeDecoratedWith<EditorIcon>();
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