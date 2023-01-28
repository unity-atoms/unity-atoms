using NUnit.Framework;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using NSubstitute;
using UnityEngine;
using System;
using FluentAssertions;

public class AtomVariableTests
{
    public class UnsupportedEvent : AtomEventBase { }

    TestObjectVariable _testObjectVariable;

    [SetUp]
    public void SetUp()
    {
        _testObjectVariable = Substitute.For<TestObjectVariable>();
    }

    [Test]
    public void Throws_Exception_when_unsupported_event_type_is_used()
    {
        UnsupportedEvent _unsupportedEvent = ScriptableObject.CreateInstance<UnsupportedEvent>();

        Assert.Throws<Exception>(() => _testObjectVariable.SetEvent(_unsupportedEvent));
    }

    [Test]
    public void Sets_Changed_if_event_type_matches()
    {
        var _event = Substitute.For<TestObjectEvent>();

        _testObjectVariable.SetEvent(_event);
        Assert.AreEqual(_testObjectVariable.Changed, _event);
    }

    [Test]
    public void Sets_ChangedWithHistory_if_event_type_matches_pair_event()
    {
        var _event = Substitute.For<TestObjectPairEvent>();

        _testObjectVariable.SetEvent(_event);
        Assert.AreEqual(_testObjectVariable.ChangedWithHistory, _event);
    }

    [Test]
    public void SetValue_is_called_when_Value_is_set()
    {

    }
}