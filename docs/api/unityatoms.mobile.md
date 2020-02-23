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

## `TouchUserInputReference`

Reference of type `TouchUserInput`. Inherits from `EquatableAtomReference<TouchUserInput, TouchUserInputConstant, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer>`.

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

## `TouchUserInputEventReference`

Event Reference of type `TouchUserInput`. Inherits from `AtomEventReference<TouchUserInput, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer>`.

---

## `TouchUserInputTouchUserInputEventReference`

Event x 2 Reference of type `TouchUserInput`. Inherits from `AtomEventX2Reference<TouchUserInput, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer>`.

---

## `TouchUserInputVariableInstancer`

Variable Instancer of type `TouchUserInput`. Inherits from `AtomVariableInstancer<TouchUserInputVariable, TouchUserInput, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction>`.

---

## `TouchUserInputVariable`

Variable of type `TouchUserInput`. Inherits from `EquatableAtomVariable<TouchUserInput, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction>`.

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

## `TouchUserInputTouchUserInputFunction`

Function x 2 of type `TouchUserInput`. Inherits from `AtomFunction<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputTouchUserInputEvent`

Event x 2 of type `TouchUserInput`. Inherits from `AtomEvent<TouchUserInput, TouchUserInput>`.

---

## `TouchUserInputEvent`

Event of type `TouchUserInput`. Inherits from `AtomEvent<TouchUserInput>`.

---

## `TouchUserInputTouchUserInputListener`

Listener x 2 of type `TouchUserInput`. Inherits from `AtomX2Listener<TouchUserInput, TouchUserInputTouchUserInputAction, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, TouchUserInputTouchUserInputEventReference, TouchUserInputTouchUserInputUnityEvent>`.

---

## `TouchUserInputListener`

Listener of type `TouchUserInput`. Inherits from `AtomListener<TouchUserInput, TouchUserInputAction, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, TouchUserInputEventReference, TouchUserInputUnityEvent>`.

---

## `TouchUserInputValueList`

Value List of type `TouchUserInput`. Inherits from `AtomValueList<TouchUserInput, TouchUserInputEvent>`.

---

## `SetTouchUserInputVariableValue`

Set variable value Action of type `TouchUserInput`. Inherits from `SetVariableValue<TouchUserInput, TouchUserInputVariable, TouchUserInputConstant, TouchUserInputReference, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputVariableInstancer>`.

---
