using NUnit.Framework;
using UnityAtoms;
using FluentAssertions;
using NSubstitute;
using System;

public class AtomBaseVariableTests
{
    [Test]
    public void Is_abstract()
    {
        typeof(AtomBaseVariable).Should().BeAbstract();
    }

    [Test]
    public void Generic_is_abstract()
    {
        typeof(AtomBaseVariable<dynamic>).Should().BeAbstract();
    }

    [Test]
    public void Has_EditorIcon_attribute()
    {
        typeof(AtomBaseVariable).Should().BeDecoratedWith<EditorIcon>();
    }

    [Test]
    public void Generic_has_EditorIcon_attribute()
    {
        typeof(AtomBaseVariable<dynamic>).Should().BeDecoratedWith<EditorIcon>();
    }

    [Test]
    public void Can_be_equated()
    {
        var _a = Substitute.For<AtomBaseVariable<dynamic>>();
        var _b = Substitute.For<AtomBaseVariable<dynamic>>();

        Assert.True(_a.Equals(_a));
        Assert.False(_a.Equals(_b));
    }
}