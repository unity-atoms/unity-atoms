---
id: unityatoms.fsm
title: UnityAtoms.FSM
hide_title: true
sidebar_label: UnityAtoms.FSM
---

# Namespace - `UnityAtoms.FSM`

## `TransitionListWrapper`

Needed in order to use our custom property drawer for transitions in the FSM.

---

## `Transition`

Controls a transition from a FromState to a ToState.

---

## `FSMTransitionData`

A struct representing a transition in a FSM.

---

## `FSMTransitionDataUnityEvent`

None generic Unity Event of type `FSMTransitionData`. Inherits from `UnityEvent<FSMTransitionData>`.

---

## `FSMTransitionDataBaseEventReferenceUsage`

Different Event Reference usages.

---

## `FSMTransitionDataBaseEventReference`

Event Reference of type `FSMTransitionData`. Inherits from `AtomBaseEventReference<FSMTransitionData, FSMTransitionDataEvent, FSMTransitionDataEventInstancer>`.

### Variables

#### `_fsm`

Takes event from this FiniteStateMachine if `Usage` is set to `FSM`.

---

#### `_fsmInstancer`

Takes event from this FiniteStateMachineInstancer if `Usage` is set to `FSM Instancer`.

### Properties

#### `Event`

Get the value for the Reference.

---

## `FSMTransitionDataEventInstancer`

Event Instancer of type `FSMTransitionData`. Inherits from `AtomEventInstancer<FSMTransitionData, FSMTransitionDataEvent>`.

---

## `FSMTransitionDataAction`

Action of type `FSMTransitionData`. Inherits from `AtomAction<FSMTransitionData>`.

---

## `FiniteStateMachineReferenceUsage`

Different usages of the FSM reference.

---

## `FiniteStateMachineReference`

Reference of type `FiniteStateMachine`. Inherits from `AtomBaseReference`.

### Variables

#### `_fsm`

Variable used if `Usage` is set to `FSM`.

---

#### `_fsmInstancer`

Variable Instancer used if `Usage` is set to `FSM_INSTANCER`.

### Properties

#### `Machine`

Get the value for the Reference.

---

## `FiniteStateMachine`

This is an implementation of an FSM in Unity Atoms. It is build using a set of states and a set of transitions. A set can only change through dispatching commands defined by the transitions.

### Variables

#### `_currentFlatValue`

The value in this state machine, disregarding a "deeper" values in a sub machine.

### Properties

#### `Value`

Get or set current value of this FSM. If a sub FSM is having the current state, then its state will be returned. Using the setter is the same thing as calling `Dispatch`.

---

#### `IsTransitioning`

Gets a boolean value indicating if the state machine is currently transitioning.

### Methods

#### `OnUpdate(System.Action{System.Single,System.String},UnityEngine.GameObject)`

Calls the handler on every Update.

##### Parameters

-   `handler` - The handler to called.
-   `gameObject` - The gameObject where this handler is setup.

---

#### `OnFixedUpdate(System.Action{System.Single,System.String},UnityEngine.GameObject)`

Calls the handler on every FixedUpdate.

##### Parameters

-   `handler` - The handler to called.
-   `gameObject` - The gameObject where this hook is setup.

---

#### `DispatchWhen(System.String,System.Func{System.String,System.Boolean},UnityEngine.GameObject)`

Defines a command that is going to automatically be dispatched when the condition provided is met.

---

#### `OnStateCooldown(System.String,System.Action{System.String},UnityEngine.GameObject)`

Called on every state cooldown.

##### Parameters

-   `state` - The state where we want to do something on the cool down.
-   `handler` - Handler to be called on cooldown.
-   `gameObject` - The gameObject where this hook is setup.

---

#### `Reset(System.Boolean)`

Reset the state machine

##### Parameters

-   `shouldTriggerEvents` - Should we trigger Change Events.

---

#### `Dispatch(System.String)`

Dispatches a new command to the FiniteStateMachine, invoking any necessary transitions.

##### Parameters

-   `command` - undefined

---

## `FiniteStateMachineMonoHook`

Needed By FiniteStateMachine in order to gain access to some of the Unity life cycle methods.

---

## `FiniteStateMachineInstancer`

Takes a base FSM and creates an in memory copy of it on OnEnable. Removes the FSM on OnDestroy.

### Variables

#### `_fsmBase`

The variable that the in memory copy will be based on when created at runtime.

---

## `FSMStateListWrapper`

Needed in order to use our custom property drawer for states in the FSM.

---

## `FSMState`

Class representing a state in the FSM.

---

## `FSMTransitionDataEvent`

Event of type `FSMTransitionData`. Inherits from `AtomEvent<FSMTransitionData>`.

---

## `FSMTransitionDataBaseEventReferenceListener`

Event Reference Listener of type `FSMTransitionData`. Inherits from `AtomEventReferenceListener<FSMTransitionData, FSMTransitionDataEvent, FSMTransitionDataBaseEventReference, FSMTransitionDataUnityEvent>`.

---
