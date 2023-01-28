using NUnit.Framework;
using UnityAtoms;
using NSubstitute;
using UnityEngine;
using System;

using ObjectVariable = UnityAtoms.AtomVariable<object, AtomVariableTests.ObjectPair, UnityAtoms.AtomEvent<object>, UnityAtoms.AtomEvent<AtomVariableTests.ObjectPair>, UnityAtoms.AtomFunction<object, object>>;

public class AtomVariableTests
{
    public struct ObjectPair : IPair<object>
    {
        public object Item1 { get => _item1; set => _item1 = value; }

        public object Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private object _item1;
        [SerializeField]
        private object _item2;
        public void Deconstruct(out object item1, out object item2) { item1 = Item1; item2 = Item2; }
    }

    public class UnsupportedEvent : AtomEventBase { }

    ObjectVariable _atomVariable;

    [SetUp]
    public void SetUp()
    {
        _atomVariable = Substitute.For<ObjectVariable>();
    }

    [Test]
    public void Throws_Exception_when_unsupported_event_type_is_used()
    {
        UnsupportedEvent _unsupportedEvent = ScriptableObject.CreateInstance<UnsupportedEvent>();

        Assert.Throws<Exception>(() => _atomVariable.SetEvent(_unsupportedEvent));
    }

    [Test]
    public void Sets_Changed_if_event_type_matches()
    {
        var _event = Substitute.For<AtomEvent<object>>();

        _atomVariable.SetEvent(_event);
        Assert.AreEqual(_atomVariable.Changed, _event);
    }

    [Test]
    public void Sets_ChangedWithHistory_if_event_type_matches_pair_event()
    {
        var _event = Substitute.For<AtomEvent<ObjectPair>>();

        _atomVariable.SetEvent(_event);
        Assert.AreEqual(_atomVariable.ChangedWithHistory, _event);
    }
}