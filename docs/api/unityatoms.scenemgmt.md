---
id: unityatoms.scenemgmt
title: UnityAtoms.SceneMgmt
hide_title: true
sidebar_label: UnityAtoms.SceneMgmt
---

# Namespace - `UnityAtoms.SceneMgmt`

## `ChangeScene`

Action to change scene.

### Variables

#### `_sceneName`

Scene to change to.

### Methods

#### `Do`

Change the scene.

---

## `QuitApplication`

Action to quit the application.

### Methods

#### `Do`

Do quit the apllication.

---

## `SceneFieldAction`

Action of type `SceneField`. Inherits from `AtomAction<SceneField>`.

---

## `SceneFieldSceneFieldAction`

Action x 2 of type `SceneField`. Inherits from `AtomAction<SceneField, SceneField>`.

---

## `SetSceneFieldVariableValue`

Set variable value Action of type `SceneField`. Inherits from `SetVariableValue<SceneField, SceneFieldVariable, SceneFieldConstant, SceneFieldReference, SceneFieldEvent, SceneFieldSceneFieldEvent>`.

---

## `SceneFieldConstant`

Constant of type `SceneField`. Inherits from `AtomBaseVariable<SceneField>`.

---

## `SceneFieldEvent`

Event of type `SceneField`. Inherits from `AtomEvent<SceneField>`.

---

## `SceneFieldSceneFieldEvent`

Event x 2 of type `SceneField`. Inherits from `AtomEvent<SceneField, SceneField>`.

---

## `SceneFieldListener`

Listener of type `SceneField`. Inherits from `AtomListener<SceneField, SceneFieldAction, SceneFieldEvent, SceneFieldUnityEvent>`.

---

## `SceneFieldSceneFieldListener`

Listener x 2 of type `SceneField`. Inherits from `AtomListener<SceneField, SceneField, SceneFieldSceneFieldAction, SceneFieldSceneFieldEvent, SceneFieldSceneFieldUnityEvent>`.

---

## `SceneFieldList`

List of type `SceneField`. Inherits from `AtomList<SceneField, SceneFieldEvent>`.

---

## `SceneFieldReference`

Reference of type `SceneField`. Inherits from `AtomReference<SceneField, SceneFieldVariable, SceneFieldConstant>`.

---

## `SceneField`

Struct to hold data about a scene.

### Variables

#### `_sceneAsset`

The scene asset.

---

#### `_sceneName`

Name of the scene.

---

#### `_scenePath`

Path to the scene asset.

---

#### `_buildIndex`

Build index.

### Properties

#### `SceneName`

Scene name as a property.

---

#### `ScenePath`

Scene path as a property.

---

#### `BuildIndex`

Build index as a property.

---

#### `SceneAsset`

Scene asset as a property.

### Methods

#### `Equals(UnityAtoms.SceneMgmt.SceneField)`

Checks for equality between 2 `SceneField`s.

##### Parameters

-   `other` - The other `SceneFiled` to compare with.

##### Returns

`true` if they are equal, otherwise `false`.

---

#### `Equals(System.Object)`

Checks for equality using `object`s.

##### Parameters

-   `other` - The other scene field as an `object` to compare with.

##### Returns

`true` if they are equal, otherwise `false`.

---

#### `GetHashCode`

Get an unique hash code for this `SceneField`.

##### Returns

An unique hash.

---

#### `op_Equality(UnityAtoms.SceneMgmt.SceneField,UnityAtoms.SceneMgmt.SceneField)`

Equal operator.

##### Parameters

-   `sf1` - The first `SceneField` to compare.
-   `sf2` - The second `SceneField` to compare.

##### Returns

`true` if eqaul, otherwise `false`.

---

#### `op_Inequality(UnityAtoms.SceneMgmt.SceneField,UnityAtoms.SceneMgmt.SceneField)`

None equality operator.

##### Parameters

-   `sf1` - The first `SceneField` to compare.
-   `sf2` - The second `SceneField` to compare.

##### Returns

`true` if not eqaul, otherwise `false`.

---

## `SceneFieldSceneFieldUnityEvent`

None generic Unity Event x 2 of type `SceneField`. Inherits from `UnityEvent<SceneField, SceneField>`.

---

## `SceneFieldUnityEvent`

None generic Unity Event of type `SceneField`. Inherits from `UnityEvent<SceneField>`.

---

## `SceneFieldVariable`

Variable of type `SceneField`. Inherits from `EquatableAtomVariable<SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent>`.

---
