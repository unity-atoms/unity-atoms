---
id: overview
title: Overview and philosopy
hide_title: true
sidebar_label: Overview and philosopy
---

# Overview and philosopy

This chapter outlines the theoretical concepts behind Unity Atoms. This knowledge helps you better understand a new way of thinking about data and state in your project.

## Fundamentals

Unity Atoms is an event based system that encourages the game to be as data-driven as possible. The four most fundamental parts of Unity Atoms are:

-   Variables
-   Events
-   Listeners
-   Actions

## Data

### Variables

Variables are data stored as [Unity's Scriptable Objects](https://docs.unity3d.com/Manual/class-ScriptableObject.html).

Because Variables are stored as Scriptable Objects they are not part of any scene, but could be instead be seen as part of a global shared game state. Variables are also designed to make them easy to inject (via the Unity Inspector) to your MonoBehaviours.

It is possible to attach an event to a Variable that gets raised when its updated. This makes it possible to write more data-driven code.

It is also possible to attach another event to a Variable that also gets raised when a Variable is changed, but that contains both the old and the new value of the Variable (see Pairs).

### Pre change transformers

You can also add pre change transformers to a Variable. A pre change transformer is an AtomFunction that takes the value type of the Variable, performs some logic, and returns a new value of the same type. It's called on `OnEnable` as well as before setting a new Value of a Variable. An example of a pre change transformer is `ClampInt`, an `IntIntFunction` that clamps the Variable's value between two values.

Your pre change transformers can contain as much or as little logic as necessary for your project and you can chain them in the Inspector.

### Constants

Constants behave exactly the same as Variables, but can not be changed via script and therefore do not contain the change events that Variables do.

### References

References are values that can be toggled between `Use Value`, `Use Constant`, `Use Variable` or `Use Variable Instancer` via the Unity Inspector.

When a Reference is set to `Use Value` it functions exactly like a regular serialized variable in a MonoBehaviour script. However, when it is set to `Use Variable` or `Use Constant` it uses a Variable or a Constant. When it's set to `Use Variable Instancer` you can drag and drop a Variable Instancer of the correct type.

### Variable Instancers

This is a MonoBehaviour that takes a base Variable and makes an in memory copy of it `OnEnable`. This is particular useful when working with prefabs that are going to be instantiated at runtime.

### Pairs

Pairs are simple structs containing two variables of the same type, used for example in Variables' Changed With History Event.

## Events

### Events

An event is a thing that happens in the game that Listeners can listen for. Events in Unity Atoms are also Scriptable Objects that live outside of a specific scene. It is possible to raise an Event from the Unity Inspector for debugging purposes.

### Pair Events

Like Event, but for pairs.

### Event References

Event References are events that can be toggled between `Use Event`, `Use Event Instancer`, `Use Variable` or `Use Variable Instancer` via the Unity Inspector. When an Event Reference is set to `Use Event` it functions exactly like a regular serialized Event in a MonoBehaviour script. When it is set to `Use Event Instancer` you can drag and drop an Event Instancer whose Event the Event Reference will use. When it is set to `Use Variable` it is going to use the Event associated with the Variable's Changed event. When it's set to `Use Variable Instancer` you can drag and drop a Variable Instancer of the correct type and it will use its associated Changed event.

### Event Instancers

This is a MonoBehaviour that takes a base Event and makes an in memory copy of it on `OnEnable`. This is particularly useful when working with prefabs that are going to be instantiated at runtime, for example when working with Mono Hooks on your prefabs.

### Pair Event Instancers

Like Event Instancer, but for pairs.

## Listeners

### Event Reference Listeners

A Listener listens to an event reference and raises zero to many responses to that Event Reference. Listeners are MonoBehaviours that live in a scene. See below for more information on the type of responses there are.

### Pair Event Reference Listeners

Like Event Reference Listeners, but for pairs.

### Event Reference Listeners

Like Event Reference Listeners, but use a regular Event instead of an Event Reference. This makes more sense in listeners observing for example Collections (see more info below).

## Responses

Responses are raised by a Listener in response to an event. Responses can live both in the scene as [UnityEvents](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) or outside the scene as a Scriptable Object in the shape of an Action.

### Actions

An Action in Unity Atoms is a C# function as a Scriptable Object. An Action can be used as a response in a Listener. Since Scriptable Objects can be created as assets in the project, Actions are well suited for responses that may have different default values.

#### Pair Actions

Like Actions, but for pairs.

### Functions

A Function in Unity Atoms is basically the same as an Action, but while an Actions does not return something a Function does.

## Collections

Collections store multiple values. For all collections in Unity Atoms there is the possibility to add Events for the following:

-   An item is added.
-   An item is removed.
-   The collection is cleared.

### Value Lists

A Value List is an array of values that is stored as a Scriptable Object.

### Lists

A List is an array of Variables that is stored as a Scriptable Object. The Variables can be different types since it's using `AtomBaseVariable`.

### Collections

A collection is a set of Variables associated with a StringReference key and is stored as a Scriptable Object. The Variables can be different types since it's using `AtomBaseVariable`.
