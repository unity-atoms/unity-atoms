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

    TestObjectVariable _substitute;
    TestObjectVariable _real;
    TestObjectEvent _event;
    TestObjectPairEvent _eventPair;
    TestObject _object;
    bool _raiseWasCalled;

    [SetUp]
    public void SetUp()
    {
        _substitute = Substitute.For<TestObjectVariable>();
        _real = ScriptableObject.CreateInstance<TestObjectVariable>();
        _event = Substitute.For<TestObjectEvent>();
        _eventPair = Substitute.For<TestObjectPairEvent>();
        _object = new TestObject();
        _raiseWasCalled = false;
    }

    [Test]
    public void Throws_Exception_when_unsupported_event_type_is_used()
    {
        UnsupportedEvent _unsupportedEvent = ScriptableObject.CreateInstance<UnsupportedEvent>();

        Assert.Throws<Exception>(() => _substitute.SetEvent(_unsupportedEvent));
    }

    [Test]
    public void Sets_Changed_if_event_type_matches()
    {
        _substitute.SetEvent(_event);
        Assert.AreEqual(_substitute.Changed, _event);
    }

    [Test]
    public void Sets_ChangedWithHistory_if_event_type_matches_pair_event()
    {
        _substitute.SetEvent(_eventPair);
        Assert.AreEqual(_substitute.ChangedWithHistory, _eventPair);
    }

    [Test]
    public void Changed_event_is_raised_when_SetValue_is_called()
    {
        _event.Register(() => _raiseWasCalled = true);
        _real.Changed = _event;
        _real.SetValue(new TestObject());

        Assert.IsTrue(_raiseWasCalled);
    }

    [Test]
    public void Changed_event_is_not_raised_if_value_does_not_change()
    {
        _event.Register(() => _raiseWasCalled = true);
        _real.Changed = _event;
        _real.SetValue(_object);
        _raiseWasCalled = false;
        _real.SetValue(_object);

        Assert.IsFalse(_raiseWasCalled);
    }

    [Test]
    public void Changed_event_raised_if_value_does_not_change_and_forceEvent_is_true()
    {
        _event.Register(() => _raiseWasCalled = true);
        _real.Changed = _event;
        _real.SetValue(_object);
        _raiseWasCalled = false;
        _real.SetValue(_object, true);

        Assert.IsTrue(_raiseWasCalled);
    }
}