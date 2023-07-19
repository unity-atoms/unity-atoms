---
id: overview
title: Overview
hide_title: true
sidebar_label: Overview
---

# UnityAtoms Documentation

UnityAtoms is a flexible and robust Unity-based framework that allows for scalable and reusable game development. It uses the idea of data-driven design, allowing you to easily create and manage game variables, events, and references, among other things.

## Overview

### References

AtomReferences provide a versatile wrapper for the inspector, abstracting the source of a value. The only requirement is that the type of the underlying value is correct.

An `AtomReference` can point to an `AtomVariable`, `AtomConstant`, `AtomInstancer`, or a pure value. 

The `EventReferences` can point to an `AtomEvent` or `AtomEventInstancer`. 

### Atom Variables

AtomVariables are assets that hold data. They can have AtomEvents assigned to raise whenever their value changes.

- **AtomConstants**: These are runtime-readonly versions of AtomVariables, offering a way to use constant values in your game logic.

- **AtomValueLists**: These are used to hold lists of AtomValues.

### Event Bus

- **AtomEvents** implement an event bus channel. They allow for values to be sent across the channel or objects to listen for them.

- **AtomEventListeners**: AtomEventListeners act as the receivers in the AtomEvents system. They register on AtomEvents (potentially filter them via **AtomConditions**), waiting for values to be broadcasted and executing AtomActions (or more).

    - *AtomConditions*, are like .NET `Predicate`. They may receive argument(s) and return a `bool`.
    - *AtomActions*, are like .NET `Action`. They may receive argument(s) and return `void`.
    - *AtomFunctions*, are like .NET `Func`. They may receive argument(s) and return a value.

## Additions

Further features of UntiyAtoms are:
- **Pairs** AtomVariables and Events can be wrapped around Tuples to provide multiple arguments on an event for example.
- **Collections** Miscellanious Collections, one is a DictionaryAtom and the other a List of AtomVariables. 

And even more (optional) Features are covered in their own Packages:
- **FSM** a FiniteStateMachine Implementation based on Atoms
- **Tags** an improvement over Unitys tagging system. Tag GameObjects based on UnityAtoms with efficient Lookup.
