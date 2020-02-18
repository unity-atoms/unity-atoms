---
id: overview
title: Overview and philosopy
hide_title: true
sidebar_label: Overview and philosopy
---

# Overview and philosopy

Unity Atoms is an event based system that encourages the game to be as data-driven as possible. The four most fundamental parts of Unity Atoms are:

-   Variables
-   Events
-   Listeners
-   Responses

## Variables

Variables are data / variables stored as Scriptable Objects. Because Variables are stored as Scriptable Objects they are not part of any scene, but could be instead be seen as part of a global shared game state. Variables are also designed to make it easy to inject (via the Unity Inspector) to your MonoBehaviours.

It is possible to attach an event to a Variable that gets raised when its updated. This makes it possible to write more data-driven code.

It is also possible to attach another event to a Variable that also gets raised when a Variable is changed, but that contains both the old and the new value of the Variable.

You can also add pre change transformers to a Variable. A pre change transformer is an AtomFunction that takes the value type of the Variable, performs some logic, and returns a new value of the same type. It's called on `OnEnable` as well as before setting a new Value of a Variable. An example of a pre change transformer is `ClampInt`, an `IntIntFunction` that clamps the Variable's value between two values.

Unity Atoms also offer some variations / additions to Variables such as Contants, References and Lists.

### Constants

Exactly the same as Variables, but can not be changed via script and therefore does not contain the change events that Variables does. The idea is to use Constants for for example tags instead of hard coding tags in your scripts.

### References

References are values that can be toggled between `Use Value`, `Use Constant`, `Use Variable` or `Use Variable Instancer` via the Unity Inspector. When a Reference is set to `Use Value` it functions exactly like a regular serialized variable in a MonoBehaviour script. However, when it is set to `Use Variable` or `Use Constant` it uses a Variable or a Constant. When it's set to `Use Variable Instancer` you can drag and drop a Variable Instancer of the correct type.

### Lists

A List is an array of values that is stored as a Scriptable Object. There is the possibility to add Events for when the following happens to the list:

-   An item is added to the List.
-   An item is removed from the List.
-   The List is cleared.

### Variable Instancer

This is a MonoBehaviour that takes a base Variable and makes an in memory copy of it `OnEnable`. This is particular useful when working with prefabs that is going to be instantiated at runtime. For example, when creating an enemy prefab you can use an `IntVariableInstancer` that creates an in memory copy of the enemy's health that you then can use in your scripts on the enemy prefab (using References).

## Events

An event is a thing that happens in the game that others can listen / subscribe to. Events in Unity Atoms are also Scriptable Objects that lives outside of a specific scene. It is possible to raise an Event from the Unity Inspector for debug purposes.

### Event References

Event References are events that can be toggled between `Use Event`, `Use Variable` or `Use Variable Instancer` via the Unity Inspector. When an Event Reference is set to `Use Event` it functions exactly like a regular serialized Event in a MonoBehaviour script. When it is set to `Use Variable` it is going to use the Event associated with the Variable's Changed event. When it's set to `Use Variable Instancer` you can drag and drop a Variable Instancer of the correct type and it will use its associated Changed event.

## Listeners

A Listener listens / observes / subscribes to an event and raises / invokes zero to many responses to that event. Listeners are MonoBehaviours and lives in a scene. See below for more information on the type of responses there are.

## Responses

A Responses is raised by a Listener in Response to an event. Responses can live both in the scene as [UnityEvents](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) or outside the scene as a Scriptable Object in the shape of an Action.

### Actions

An Action in Unity Atoms is a C# function as a Scriptable Object. An Action can be used as a response in a Listener.

### Functions

A Function in Unity Atoms is basically the same as an Action, but while an Actions does not return something a Function does.
