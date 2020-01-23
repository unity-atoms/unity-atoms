---
id: unityatoms.mobile
title: UnityAtoms.Mobile
hide_title: true
sidebar_label: UnityAtoms.Mobile
---

# Namespace - `UnityAtoms.Mobile`

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

## `TouchUserInputList`

List of type `TouchUserInput`. Inherits from `AtomList<TouchUserInput, TouchUserInputEvent>`.

---

## `TouchUserInputReference`

Reference of type `TouchUserInput`. Inherits from `AtomReference<TouchUserInput, TouchUserInputVariable, TouchUserInputConstant>`.

---

## `TouchUserInputUnityEvent`

None generic Unity Event of type `TouchUserInput`. Inherits from `UnityEvent<TouchUserInput>`.

---

## `TouchUserInputTouchUserInputUnityEvent`

None generic Unity Event x 2 of type `TouchUserInput`. Inherits from `UnityEvent<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputConstant`

Constant of type `TouchUserInput`. Inherits from `AtomBaseVariable<TouchUserInput>`.

---

## `TouchUserInputVariable`

Variable of type `TouchUserInput`. Inherits from `EquatableAtomVariable<TouchUserInput, TouchUserInputEvent, TouchUserInputTouchUserInputEvent>`.

---

## `TouchUserInputTouchUserInputAction`

Action x 2 of type `TouchUserInput`. Inherits from `AtomAction<TouchUserInput, TouchUserInput>`.

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

## `TouchUserInputAction`

Action of type `TouchUserInput`. Inherits from `AtomAction<TouchUserInput>`.

---

## `TouchUserInputTouchUserInputEvent`

Event x 2 of type `TouchUserInput`. Inherits from `AtomEvent<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputEvent`

Event of type `TouchUserInput`. Inherits from `AtomEvent<TouchUserInput>`.

---

## `TouchUserInputTouchUserInputListener`

Listener x 2 of type `TouchUserInput`. Inherits from `AtomListener<TouchUserInput, TouchUserInput, TouchUserInputTouchUserInputAction, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputUnityEvent>`.

---

## `TouchUserInputListener`

Listener of type `TouchUserInput`. Inherits from `AtomListener<TouchUserInput, TouchUserInputAction, TouchUserInputEvent, TouchUserInputUnityEvent>`.

---

## `SetTouchUserInputVariableValue`

Set variable value Action of type `TouchUserInput`. Inherits from `SetVariableValue<TouchUserInput, TouchUserInputVariable, TouchUserInputConstant, TouchUserInputReference, TouchUserInputEvent, TouchUserInputTouchUserInputEvent>`.

---
