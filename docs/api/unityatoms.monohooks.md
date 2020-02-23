---
id: unityatoms.monohooks
title: UnityAtoms.MonoHooks
hide_title: true
sidebar_label: UnityAtoms.MonoHooks
---

# Namespace - `UnityAtoms.MonoHooks`

## `OnDestroyHook`

Mono Hook for [`OnDestroy`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDestroy.html)

---

## `ColliderHook`

Base class for all `MonoHook`s of type `Collider`.

---

## `OnUpdateHook`

Mono Hook for [`Update`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html)

---

## `OnTrigger2DHook`

Mono Hook for [`OnTriggerEnter2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html), [`OnTriggerExit2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerExit2D.html) and [`OnTriggerStay2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerStay2D.html)

### Variables

#### `_triggerOnEnter`

Set to true if Event should be triggered on `OnTriggerEnter2D`

---

#### `_triggerOnExit`

Set to true if Event should be triggered on `OnTriggerExit2D`

---

#### `_triggerOnStay`

Set to true if Event should be triggered on `OnTriggerStay2D`

---

## `OnTriggerHook`

Mono Hook for [`OnTriggerEnter`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter.html), [`OnTriggerExit`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerExit.html) and [`OnTriggerStay`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerStay.html)

### Variables

#### `_triggerOnEnter`

Set to true if Event should be triggered on `OnTriggerEnter`

---

#### `_triggerOnExit`

Set to true if Event should be triggered on `OnTriggerExit`

---

#### `_triggerOnStay`

Set to true if Event should be triggered on `OnTriggerStay`

---

## `MonoHook<E1,E2,EV,F>`

#### Type Parameters

-   `E1` - Event of type `AtomEvent<EV>`
-   `E2` - Event of type `AtomEvent<EV, GameObject>`
-   `EV` - Event value type
-   `F` - Function type `AtomFunction<GameObject, GameObject>`

Generic base class for all Mono Hooks.

### Variables

#### `Event`

The Event

---

#### `EventWithGameObjectReference`

Event including a GameObject reference.

---

#### `_selectGameObjectReference`

Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.

---

## `OnLateUpdateHook`

Mono Hook for [`LateUpdate`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html)

---

## `OnButtonClickHook`

Mono Hook for On Button Click

---

## `OnFixedUpdateHook`

Mono Hook for [`FixedUpdate`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html)

---

## `OnPointerDownHook`

Mono Hook for `OnPointerDown`

---

## `Collider2DHook`

Base class for all `MonoHook`s of type `Collider2D`.

---

## `OnAwakeHook`

Mono Hook for [`Awake`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html).

### Variables

#### `_listener`

Listener

---

#### `_gameObjectListener`

Listener with GameObject reference

---

## `OnStartHook`

Mono Hook for [`Start`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html)

---

## `VoidHook`

Base class for all `MonoHook`s of type `Void`.

### Variables

#### `_event`

The Event

---

#### `_eventWithGameObjectReference`

Event including a GameObject reference.

---

#### `_selectGameObjectReference`

Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.

---

## `ColliderGameObjectEvent`

Event x 2 of type `Collider` and `GameObject`. Inherits from `AtomEvent<Collider, GameObject>`.

---

## `Collider2DGameObjectEvent`

Event x 2 of type `Collider2D` and `GameObject`. Inherits from `AtomEvent<Collider2D, GameObject>`.

---
