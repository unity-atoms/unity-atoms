using NUnit.Framework;
using UnityAtoms.BaseAtoms;
using FluentAssertions;
using UnityEngine;
using System;

public class IntVariableTests
{
    IntVariable _intVariable;

    [SetUp]
    public void SetUp()
    {
        _intVariable = ScriptableObject.CreateInstance<IntVariable>();
    }

    [TearDown]
    public void TearDown()
    {
        ScriptableObject.DestroyImmediate(_intVariable);
    }

    [Test]
    public void Assigning_value_retains_value()
    {
        _intVariable.Value = 1;
        _intVariable.Value.Should().Be(1);

        _intVariable.Value = 2;
        _intVariable.Value.Should().Be(2);
    }

    [Test]
    public void Assigning_new_value_sets_old_value()
    {
        _intVariable.Value = 1;
        _intVariable.Value = 2;

        _intVariable.OldValue.Should().Be(1);

        _intVariable.Value = 3;

        _intVariable.OldValue.Should().Be(2);
    }

}