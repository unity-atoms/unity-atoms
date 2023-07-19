---
id: overview
title: Philosophy
hide_title: true
sidebar_label: Overview and Philosophy
---

:::caution

The following Content was written by Chat-GPT and only proofread by Soraphis

:::

# ScriptableObject Architecture (SOA) in Unity
[Scriptable Object](https://docs.unity3d.com/Manual/class-ScriptableObject.html) Architecture (SOA) is a design pattern that aims to facilitate scalable, maintainable, and testable game development using Unity. This concept was popularized by [Ryan Hipple in his 2017 GDC talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) where he introduced the concept of ScriptableObjects as a way to create modular, data-driven systems within Unity.

## The Philosophy of SOA
The underlying philosophy of the SOA revolves around the following principles:

**Decoupling**: Reducing dependencies between components to make them more flexible and easier to maintain and test.
**Modularity**: Creating self-contained, independent pieces that can be plugged together to build complex systems.
**Data Oriented**: Centralizing and externalizing data for better management and debugging.
ScriptableObject, a type of object in Unity that allows developers to create assets in the Unity Editor that store large amounts of shared data, is a key component in this architecture.

## Key Pillars of SOA
SOA relies heavily on two main pillars:

**Modular Data**: Instead of hard coding data within our code, we externalize the data using ScriptableObjects. This allows for the separation of data and logic, making it easier to manage data and reuse it in different parts of the system.
**Event Architecture**: This refers to the usage of ScriptableObjects as events (or event busses). In this system, ScriptableObjects act as channels where different parts of our system can subscribe to and broadcast events.

## UnityAtoms: An SOA Implementation
UnityAtoms offers a robust implementation of the SOA. It's an extension of the ScriptableObject system, with a focus on making it easier to create and manage ScriptableObject-based code.

### Features of UnityAtoms

**ScriptableObject Variables**: UnityAtoms allows for the creation of AtomVariables, ScriptableObjects containing values. It comes with a lot of built in types and provides easy code generation for custom types.
**Game Events**: UnityAtoms uses AtomEvents, a form of ScriptableObject, to enable communication between scripts without direct references. These game events can be listened to by multiple scripts, allowing for a flexible and decoupled system.
**Customizable and Extensible**: UnityAtoms is designed to be flexible and can be extended to suit the specific needs of your game project.


### Using UnityAtoms
UnityAtoms provides a collection of base classes that can be extended to create specific implementations for your game. It offers AtomVariable, Instancers, Collections, AtomEvent, AtomAction, and AtomCondition, among others, which can be combined to implement complex game logic.

Furthermore it offers additional features built on top of the SOA architecture like FSM, Tagging, Input and more.

## Conclusion
SOA and UnityAtoms offer a great way to structure your Unity projects, providing a more maintainable, scalable, and testable codebase. The modular nature of this architecture allows for easy expansion of your game, ensuring that your codebase remains manageable as your game grows in complexity.