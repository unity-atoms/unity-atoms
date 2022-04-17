---
id: unityatoms.mobile
title: UnityAtoms.Mobile
hide_title: true
sidebar_label: UnityAtoms.Mobile
---

# Namespace - `UnityAtoms.Mobile`

## `TouchUserInputAction`

Action of type `TouchUserInput`. Inherits from `AtomAction<TouchUserInput>`.

---

## `TouchUserInputPairAction`

Action of type `TouchUserInputPair`. Inherits from `AtomAction<TouchUserInputPair>`.

---

## `UpdateTouchUserInput`

Updates the `TouchUserInputVariable` on every Update tick. Meant to be called every Update.

### Variables

#### `TouchUserInputVariable`

The `TouchUserInputVariable` to update.

### Methods

#### `Do`

Update the `TouchUserInputVariable`.abstract Call this on every Update tick.

---

## `SetTouchUserInputVariableValue`

Set variable value Action of type `TouchUserInput`. Inherits from `SetVariableValue<TouchUserInput, TouchUserInputPair, TouchUserInputVariable, TouchUserInputConstant, TouchUserInputReference, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputVariableInstancer>`.

---

## `TouchUserInputCondition`

Condition of type `TouchUserInput`. Inherits from `AtomCondition<TouchUserInput>`.

---

## `TouchUserInputConstant`

Constant of type `TouchUserInput`. Inherits from `AtomBaseVariable<TouchUserInput>`.

---

## `TouchUserInputEventInstancer`

Event Instancer of type `TouchUserInput`. Inherits from `AtomEventInstancer<TouchUserInput, TouchUserInputEvent>`.

---

## `TouchUserInputPairEventInstancer`

Event Instancer of type `TouchUserInputPair`. Inherits from `AtomEventInstancer<TouchUserInputPair, TouchUserInputPairEvent>`.

---

## `TouchUserInputEventReferenceListener`

Event Reference Listener of type `TouchUserInput`. Inherits from `AtomEventReferenceListener<TouchUserInput, TouchUserInputEvent, TouchUserInputEventReference, TouchUserInputUnityEvent>`.

---

## `TouchUserInputPairEventReferenceListener`

Event Reference Listener of type `TouchUserInputPair`. Inherits from `AtomEventReferenceListener<TouchUserInputPair, TouchUserInputPairEvent, TouchUserInputPairEventReference, TouchUserInputPairUnityEvent>`.

---

## `TouchUserInputEventReference`

Event Reference of type `TouchUserInput`. Inherits from `AtomEventReference<TouchUserInput, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputVariableInstancer, TouchUserInputEventInstancer>`.

---

## `TouchUserInputPairEventReference`

Event Reference of type `TouchUserInputPair`. Inherits from `AtomEventReference<TouchUserInputPair, TouchUserInputVariable, TouchUserInputPairEvent, TouchUserInputVariableInstancer, TouchUserInputPairEventInstancer>`.

---

## `TouchUserInputEvent`

Event of type `TouchUserInput`. Inherits from `AtomEvent<TouchUserInput>`.

---

## `TouchUserInputPairEvent`

Event of type `TouchUserInputPair`. Inherits from `AtomEvent<TouchUserInputPair>`.

---

## `TouchUserInputTouchUserInputFunction`

Function x 2 of type `TouchUserInput`. Inherits from `AtomFunction<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputPair`

IPair of type `<TouchUserInput>`. Inherits from `IPair<TouchUserInput>`.

---

## `TouchUserInputReference`

Reference of type `TouchUserInput`. Inherits from `EquatableAtomReference<TouchUserInput, TouchUserInputPair, TouchUserInputConstant, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, AtomCollection, AtomList>`.

---

## `SyncTouchUserInputVariableInstancerToCollection`

Adds Variable Instancer's Variable of type TouchUserInput to a Collection or List on OnEnable and removes it on OnDestroy.

---

## `TouchUserInput`

Module class holding data for touch user input.

### Variables

#### `InputState`

Current input state.

---

#### `InputPos`

Current input position.

---

#### `InputPosLastFrame`

Input position last frame.

---

#### `InputPosLastDown`

Input position last time the user pressed down.

### Properties

#### `InputWorldPos`

The input position in world space.

---

#### `InputWorldPosLastFrame`

The input position in world space from last frame.

---

#### `InputWorldPosLastDown`

Input position last time the user pressed down in world space.

### Methods

#### `#ctor(UnityAtoms.Mobile.TouchUserInput.State,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2)`

Create a `TouchUserInput` class.

##### Parameters

-   `inputState` - Initial input state.
-   `inputPos` - Initial input position.
-   `inputPosLastFrame` - Initial input position last frame.
-   `inputPosLastDown` - Initial input position last time the user pressed down.

---

#### `Equals(UnityAtoms.Mobile.TouchUserInput)`

Determine if 2 `TouchUserInput` are equal.

##### Parameters

-   `other` - The other `TouchUserInput` to compare with.

##### Returns

`true` if equal, otherwise `false`.

---

#### `Equals(System.Object)`

Determine if 2 `TouchUserInput` are equal comparing against another `object`.

##### Parameters

-   `obj` - The other `object` to compare with.

##### Returns

`true` if equal, otherwise `false`.

---

#### `GetHashCode`

`GetHashCode()` in order to implement `IEquatable<TouchUserInput>`

##### Returns

An unique hashcode for the current value.

---

#### `op_Equality(UnityAtoms.Mobile.TouchUserInput,UnityAtoms.Mobile.TouchUserInput)`

Equality operator

##### Parameters

-   `touch1` - First `TouchUserInput`.
-   `touch2` - Other `TouchUserInput`.

##### Returns

`true` if equal, otherwise `false`.

---

#### `op_Inequality(UnityAtoms.Mobile.TouchUserInput,UnityAtoms.Mobile.TouchUserInput)`

Inequality operator

##### Parameters

-   `touch1` - First `TouchUserInput`.
-   `touch2` - Other `TouchUserInput`.

##### Returns

`true` if they are not equal, otherwise `false`.

---

## `TouchUserInput.State`

Enum for different touch user input states.

---

## `TouchUserInputPairUnityEvent`

None generic Unity Event of type `TouchUserInputPair`. Inherits from `UnityEvent<TouchUserInputPair>`.

---

## `TouchUserInputTouchUserInputUnityEvent`

None generic Unity Event x 2 of type `TouchUserInput`. Inherits from `UnityEvent<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputUnityEvent`

None generic Unity Event of type `TouchUserInput`. Inherits from `UnityEvent<TouchUserInput>`.

---

## `TouchUserInputValueList`

Value List of type `TouchUserInput`. Inherits from `AtomValueList<TouchUserInput, TouchUserInputEvent>`.

---

## `TouchUserInputVariableInstancer`

Variable Instancer of type `TouchUserInput`. Inherits from `AtomVariableInstancer<TouchUserInputVariable, TouchUserInputPair, TouchUserInput, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction>`.

---

## `TouchUserInputVariable`

Variable of type `TouchUserInput`. Inherits from `EquatableAtomVariable<TouchUserInput, TouchUserInputPair, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction>`.

---
