---
id: unityatoms.scenemgmt
title: UnityAtoms.SceneMgmt
hide_title: true
sidebar_label: UnityAtoms.SceneMgmt
---

# Namespace - `UnityAtoms.SceneMgmt`

## `SceneFieldPairEventReferenceListener`

Event Reference Listener of type `SceneFieldPair`. Inherits from `AtomEventReferenceListener<SceneFieldPair, SceneFieldPairEvent, SceneFieldPairEventReference, SceneFieldPairUnityEvent>`.

---

## `SceneFieldEventReferenceListener`

Event Reference Listener of type `SceneField`. Inherits from `AtomEventReferenceListener<SceneField, SceneFieldEvent, SceneFieldEventReference, SceneFieldUnityEvent>`.

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

## `SceneFieldReference`

Reference of type `SceneField`. Inherits from `EquatableAtomReference<SceneField, SceneFieldPair, SceneFieldConstant, SceneFieldVariable, SceneFieldEvent, SceneFieldPairEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer, AtomCollection, AtomList>`.

---

## `SceneFieldPair`

IPair of type `<SceneField>`. Inherits from `IPair<SceneField>`.

---

## `SceneFieldPairUnityEvent`

None generic Unity Event of type `SceneFieldPair`. Inherits from `UnityEvent<SceneFieldPair>`.

---

## `SceneFieldSceneFieldUnityEvent`

None generic Unity Event x 2 of type `SceneField`. Inherits from `UnityEvent<SceneField, SceneField>`.

---

## `SceneFieldUnityEvent`

None generic Unity Event of type `SceneField`. Inherits from `UnityEvent<SceneField>`.

---

## `SceneFieldConstant`

Constant of type `SceneField`. Inherits from `AtomBaseVariable<SceneField>`.

---

## `SceneFieldPairEventReference`

Event Reference of type `SceneFieldPair`. Inherits from `AtomEventReference<SceneFieldPair, SceneFieldVariable, SceneFieldPairEvent, SceneFieldVariableInstancer, SceneFieldPairEventInstancer>`.

---

## `SceneFieldEventReference`

Event Reference of type `SceneField`. Inherits from `AtomEventReference<SceneField, SceneFieldVariable, SceneFieldEvent, SceneFieldVariableInstancer, SceneFieldEventInstancer>`.

---

## `SceneFieldVariableInstancer`

Variable Instancer of type `SceneField`. Inherits from `AtomVariableInstancer<SceneFieldVariable, SceneFieldPair, SceneField, SceneFieldEvent, SceneFieldPairEvent, SceneFieldSceneFieldFunction>`.

---

## `SceneFieldEventInstancer`

Event Instancer of type `SceneField`. Inherits from `AtomEventInstancer<SceneField, SceneFieldEvent>`.

---

## `SceneFieldPairEventInstancer`

Event Instancer of type `SceneFieldPair`. Inherits from `AtomEventInstancer<SceneFieldPair, SceneFieldPairEvent>`.

---

## `SceneFieldVariable`

Variable of type `SceneField`. Inherits from `EquatableAtomVariable<SceneField, SceneFieldPair, SceneFieldEvent, SceneFieldPairEvent, SceneFieldSceneFieldFunction>`.

---

## `SceneFieldPairAction`

Action of type `SceneFieldPair`. Inherits from `AtomAction<SceneFieldPair>`.

---

## `QuitApplication`

Action to quit the application.

### Methods

#### `Do`

Do quit the apllication.

---

## `ChangeScene`

Action to change scene.

### Variables

#### `_sceneName`

Scene to change to.

### Methods

#### `Do`

Change the scene.

---

## `SceneFieldAction`

Action of type `SceneField`. Inherits from `AtomAction<SceneField>`.

---

## `SceneFieldSceneFieldFunction`

Function x 2 of type `SceneField`. Inherits from `AtomFunction<SceneField, SceneField>`.

---

## `SyncSceneFieldVariableInstancerToCollection`

Adds Variable Instancer's Variable of type SceneField to a Collection or List on OnEnable and removes it on OnDestroy.

---

## `SceneFieldPairEvent`

Event of type `SceneFieldPair`. Inherits from `AtomEvent<SceneFieldPair>`.

---

## `SceneFieldEvent`

Event of type `SceneField`. Inherits from `AtomEvent<SceneField>`.

---

## `SceneFieldValueList`

Value List of type `SceneField`. Inherits from `AtomValueList<SceneField, SceneFieldEvent>`.

---

## `SetSceneFieldVariableValue`

Set variable value Action of type `SceneField`. Inherits from `SetVariableValue<SceneField, SceneFieldPair, SceneFieldVariable, SceneFieldConstant, SceneFieldReference, SceneFieldEvent, SceneFieldPairEvent, SceneFieldVariableInstancer>`.

---
