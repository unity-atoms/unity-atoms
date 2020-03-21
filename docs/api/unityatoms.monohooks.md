---
id: unityatoms.monohooks
title: UnityAtoms.MonoHooks
hide_title: true
sidebar_label: UnityAtoms.MonoHooks
---

# Namespace - `UnityAtoms.MonoHooks`

## `Collider2DGameObjectEventReferenceListener`

Event Reference Listener of type `Collider2DGameObject`. Inherits from `AtomEventReferenceListener<Collider2DGameObject, Collider2DGameObjectEvent, Collider2DGameObjectEventReference, Collider2DGameObjectUnityEvent>`.

---

## `ColliderGameObjectEventReferenceListener`

Event Reference Listener of type `ColliderGameObject`. Inherits from `AtomEventReferenceListener<ColliderGameObject, ColliderGameObjectEvent, ColliderGameObjectEventReference, ColliderGameObjectUnityEvent>`.

---

## `Collider2DGameObjectPairEventReferenceListener`

Event Reference Listener of type `Collider2DGameObjectPair`. Inherits from `AtomEventReferenceListener<Collider2DGameObjectPair, Collider2DGameObjectPairEvent, Collider2DGameObjectPairEventReference, Collider2DGameObjectPairUnityEvent>`.

---

## `ColliderGameObjectPairEventReferenceListener`

Event Reference Listener of type `ColliderGameObjectPair`. Inherits from `AtomEventReferenceListener<ColliderGameObjectPair, ColliderGameObjectPairEvent, ColliderGameObjectPairEventReference, ColliderGameObjectPairUnityEvent>`.

---

## `ColliderGameObjectReference`

Reference of type `ColliderGameObject`. Inherits from `EquatableAtomReference<ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectConstant, ColliderGameObjectVariable, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction, ColliderGameObjectVariableInstancer, AtomCollection, AtomList>`.

---

## `Collider2DGameObjectReference`

Reference of type `Collider2DGameObject`. Inherits from `EquatableAtomReference<Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectConstant, Collider2DGameObjectVariable, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction, Collider2DGameObjectVariableInstancer, AtomCollection, AtomList>`.

---

## `Collider2DGameObjectPair`

IPair of type `<Collider2DGameObject>`. Inherits from `IPair<Collider2DGameObject>`.

---

## `ColliderGameObjectPair`

IPair of type `<ColliderGameObject>`. Inherits from `IPair<ColliderGameObject>`.

---

## `Collider2DGameObjectUnityEvent`

None generic Unity Event of type `Collider2DGameObject`. Inherits from `UnityEvent<Collider2DGameObject>`.

---

## `Collider2DGameObjectPairUnityEvent`

None generic Unity Event of type `Collider2DGameObjectPair`. Inherits from `UnityEvent<Collider2DGameObjectPair>`.

---

## `ColliderGameObjectPairUnityEvent`

None generic Unity Event of type `ColliderGameObjectPair`. Inherits from `UnityEvent<ColliderGameObjectPair>`.

---

## `ColliderGameObjectUnityEvent`

None generic Unity Event of type `ColliderGameObject`. Inherits from `UnityEvent<ColliderGameObject>`.

---

## `ColliderGameObjectConstant`

Constant of type `ColliderGameObject`. Inherits from `AtomBaseVariable<ColliderGameObject>`.

---

## `Collider2DGameObjectConstant`

Constant of type `Collider2DGameObject`. Inherits from `AtomBaseVariable<Collider2DGameObject>`.

---

## `ColliderGameObjectPairEventReference`

Event Reference of type `ColliderGameObjectPair`. Inherits from `AtomEventReference<ColliderGameObjectPair, ColliderGameObjectVariable, ColliderGameObjectPairEvent, ColliderGameObjectVariableInstancer, ColliderGameObjectPairEventInstancer>`.

---

## `Collider2DGameObjectEventReference`

Event Reference of type `Collider2DGameObject`. Inherits from `AtomEventReference<Collider2DGameObject, Collider2DGameObjectVariable, Collider2DGameObjectEvent, Collider2DGameObjectVariableInstancer, Collider2DGameObjectEventInstancer>`.

---

## `Collider2DGameObjectPairEventReference`

Event Reference of type `Collider2DGameObjectPair`. Inherits from `AtomEventReference<Collider2DGameObjectPair, Collider2DGameObjectVariable, Collider2DGameObjectPairEvent, Collider2DGameObjectVariableInstancer, Collider2DGameObjectPairEventInstancer>`.

---

## `ColliderGameObjectEventReference`

Event Reference of type `ColliderGameObject`. Inherits from `AtomEventReference<ColliderGameObject, ColliderGameObjectVariable, ColliderGameObjectEvent, ColliderGameObjectVariableInstancer, ColliderGameObjectEventInstancer>`.

---

## `ColliderGameObjectVariableInstancer`

Variable Instancer of type `ColliderGameObject`. Inherits from `AtomVariableInstancer<ColliderGameObjectVariable, ColliderGameObjectPair, ColliderGameObject, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction>`.

---

## `Collider2DGameObjectVariableInstancer`

Variable Instancer of type `Collider2DGameObject`. Inherits from `AtomVariableInstancer<Collider2DGameObjectVariable, Collider2DGameObjectPair, Collider2DGameObject, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction>`.

---

## `ColliderGameObjectEventInstancer`

Event Instancer of type `ColliderGameObject`. Inherits from `AtomEventInstancer<ColliderGameObject, ColliderGameObjectEvent>`.

---

## `Collider2DGameObjectPairEventInstancer`

Event Instancer of type `Collider2DGameObjectPair`. Inherits from `AtomEventInstancer<Collider2DGameObjectPair, Collider2DGameObjectPairEvent>`.

---

## `ColliderGameObjectPairEventInstancer`

Event Instancer of type `ColliderGameObjectPair`. Inherits from `AtomEventInstancer<ColliderGameObjectPair, ColliderGameObjectPairEvent>`.

---

## `Collider2DGameObjectEventInstancer`

Event Instancer of type `Collider2DGameObject`. Inherits from `AtomEventInstancer<Collider2DGameObject, Collider2DGameObjectEvent>`.

---

## `Collider2DGameObjectVariable`

Variable of type `Collider2DGameObject`. Inherits from `EquatableAtomVariable<Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction>`.

---

## `ColliderGameObjectVariable`

Variable of type `ColliderGameObject`. Inherits from `EquatableAtomVariable<ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction>`.

---

## `OnDestroyHook`

Mono Hook for [`OnDestroy`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDestroy.html)

---

## `ColliderHook`

Base class for all `MonoHook`s of type `Collider`.

### Properties

#### `EventWithGameObject`

Event including a GameObject reference.

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

## `MonoHook<E,EV,F>`

#### Type Parameters

-   `E` - Event of type `AtomEvent<EV>`
-   `EV` - Event value type
-   `F` - Function type `AtomFunction<GameObject, GameObject>`

Generic base class for all Mono Hooks.

### Variables

#### `_selectGameObjectReference`

Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.

### Properties

#### `Event`

The Event

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

### Properties

#### `EventWithGameObject`

Event including a GameObject reference.

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

Base class for all `MonoHook`s of type `AtomEventBase`.

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

## `Collider2DGameObjectAction`

Action of type `Collider2DGameObject`. Inherits from `AtomAction<Collider2DGameObject>`.

---

## `Collider2DGameObjectPairAction`

Action of type `Collider2DGameObjectPair`. Inherits from `AtomAction<Collider2DGameObjectPair>`.

---

## `ColliderGameObjectPairAction`

Action of type `ColliderGameObjectPair`. Inherits from `AtomAction<ColliderGameObjectPair>`.

---

## `ColliderGameObjectAction`

Action of type `ColliderGameObject`. Inherits from `AtomAction<ColliderGameObject>`.

---

## `Collider2DGameObjectCollider2DGameObjectFunction`

Function x 2 of type `Collider2DGameObject`. Inherits from `AtomFunction<Collider2DGameObject, Collider2DGameObject>`.

---

## `ColliderGameObjectColliderGameObjectFunction`

Function x 2 of type `ColliderGameObject`. Inherits from `AtomFunction<ColliderGameObject, ColliderGameObject>`.

---

## `SyncCollider2DGameObjectVariableInstancerToCollection`

Adds Variable Instancer's Variable of type Collider2DGameObject to a Collection or List on OnEnable and removes it on OnDestroy.

---

## `SyncColliderGameObjectVariableInstancerToCollection`

Adds Variable Instancer's Variable of type ColliderGameObject to a Collection or List on OnEnable and removes it on OnDestroy.

---

## `ColliderGameObjectPairEvent`

Event of type `ColliderGameObjectPair`. Inherits from `AtomEvent<ColliderGameObjectPair>`.

---

## `ColliderGameObjectEvent`

Event of type `ColliderGameObject`. Inherits from `AtomEvent<ColliderGameObject>`.

---

## `Collider2DGameObjectEvent`

Event of type `Collider2DGameObject`. Inherits from `AtomEvent<Collider2DGameObject>`.

---

## `Collider2DGameObjectPairEvent`

Event of type `Collider2DGameObjectPair`. Inherits from `AtomEvent<Collider2DGameObjectPair>`.

---

## `ColliderGameObjectValueList`

Value List of type `ColliderGameObject`. Inherits from `AtomValueList<ColliderGameObject, ColliderGameObjectEvent>`.

---

## `Collider2DGameObjectValueList`

Value List of type `Collider2DGameObject`. Inherits from `AtomValueList<Collider2DGameObject, Collider2DGameObjectEvent>`.

---

## `SetCollider2DGameObjectVariableValue`

Set variable value Action of type `Collider2DGameObject`. Inherits from `SetVariableValue<Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectVariable, Collider2DGameObjectConstant, Collider2DGameObjectReference, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectVariableInstancer>`.

---

## `SetColliderGameObjectVariableValue`

Set variable value Action of type `ColliderGameObject`. Inherits from `SetVariableValue<ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectVariable, ColliderGameObjectConstant, ColliderGameObjectReference, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectVariableInstancer>`.

---
