---
id: philosophy
title: Philosophy
hide_title: true
sidebar_label: Philosophy
---

# Philosophy

This page describes the foundation and philosophy of which Unity Atoms is built upon.

## ScriptableObject Architecture (SOA)
[ScriptableObject](https://docs.unity3d.com/Manual/class-ScriptableObject.html) Architecture (SOA) is a design pattern that aims to facilitate scalable, maintainable, and testable game development using Unity. This concept was popularized by [Ryan Hipple in his 2017 GDC talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) where he introduced the concept of ScriptableObjects as the glue that makes it possible to create modular and data-driven systems within Unity.

## Pillars of SOA

There are 3 main pillars of SOA: 

- **Modular** - Systems in your game should not be directly depdendent on each other. Hard references between systems makes them less flexible and harder to reiterate on and reassemble. To make systems that are modular, it's a good rule to keep scenes as clean slates, meaning that we avoid `DontDestoryOnLoad` objects as much as possible. Furthermore, prefabs should as much as possible work on their own without any manager or other systems needed in the scene. Last but not least, Unity is a component based engine, create and use components that do one thing and one thing only.
-  **Editable** - The systems you create should be data-driven, eg. take data as input and process that data. The input and output of those systems should be editable and this is achieved by utilizing Unity's inspector. This approach allows us to change the game without changing code. Writing editable and with modular systems also allows us to reassemble systems in different ways, which is a great way to iterate on new game mechanics. Lastly, being editable means that we can change stuff at runtime, which greatly reduces iteration times. 
-  **Debuggable** - If your systems are modular the easier they are to test in isolation. Furtermore, editable systems naturally provides debug views where you can see the data that is being processed.

## How SOA achieves its goals

- **Data** - Instead of hard coding data within our code, we externalize the data using ScriptableObjects. This allows for the separation of data and logic, making it easier to manage data and reuse it in different parts of the game.
- **Events** - We use ScriptableObjects as events. This allows us to broadcast data across different parts of our game without having to know who is listening. 

## UnityAtoms: A SOA implementation
UnityAtoms offers a robust implementation of the SOA. It's an extension of the ScriptableObject system, with a focus on making it easier to create and manage ScriptableObject-based code. It provides Variables, Instancers, Collections, Events, Actions, and Conditions, among others, which can be combined to implement complex game logic. Furthermore, it provides additional features built on top of the SOA architecture like FSM, Tagging, Input System and more.

SOA and UnityAtoms is a great way to structure your Unity projects, providing a more maintainable, scalable, and testable codebase. The modular nature of this architecture allows for easy expansion of your game, ensuring that your codebase remains manageable as your game grows in complexity.
