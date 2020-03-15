---
id: unityatoms
title: UnityAtoms
hide_title: true
sidebar_label: UnityAtoms
---

# Namespace - `UnityAtoms`

## `IMGUIUtils`

Utility methods for IMGUI.

### Methods

#### `SnipRectH(UnityEngine.Rect,System.Single)`

Snip a `Rect` horizontally.

##### Parameters

-   `rect` - The rect.
-   `range` - The range.

##### Returns

A new `Rect` snipped horizontally.

---

#### `SnipRectH(UnityEngine.Rect,System.Single,UnityEngine.Rect@,System.Single)`

Snip a `Rect` horizontally.

##### Parameters

-   `rect` - The rect.
-   `range` - The range.
-   `rest` - Rest rect.
-   `gutter` - Gutter

##### Returns

A new `Rect` snipped horizontally.

---

#### `SnipRectV(UnityEngine.Rect,System.Single)`

Snip a `Rect` vertically.

##### Parameters

-   `rect` - The rect.
-   `range` - The range.

##### Returns

A new `Rect` snipped vertically.

---

#### `SnipRectV(UnityEngine.Rect,System.Single,UnityEngine.Rect@,System.Single)`

Snip a `Rect` vertically.

##### Parameters

-   `rect` - The rect.
-   `range` - The range.
-   `rest` - Rest rect.
-   `gutter` - Gutter

##### Returns

A new `Rect` snipped vertically.

---

## `StringReferenceAtomBaseVariableDictionary`

A SerializableDictionary of type StringReference and AtomBaseVariable. Used by AtomCollection.

### Methods

#### `Get<T>(System.String)`

Generic getter.

#### Type Parameters

-   `T` - The expected type of the value you want to retrieve.

##### Parameters

-   `key` - The key associated with the value you want to retrieve.

##### Returns

The value of type T if found, otherwise null.

---

#### `Get<T>(UnityAtoms.AtomBaseVariable{System.String})`

Generic getter.

#### Type Parameters

-   `T` - The expected type of the value you want to retrieve.

##### Parameters

-   `key` - The key associated with the value you want to retrieve.

##### Returns

The value of type T if found, otherwise null.

---

#### `Add(System.String,UnityAtoms.AtomBaseVariable)`

Add value and its associated key to the dictionary.

##### Parameters

-   `key` - The key associated with the value.
-   `value` - The value to add.

---

#### `Add(UnityAtoms.AtomBaseVariable{System.String},UnityAtoms.AtomBaseVariable)`

Add value and its associated key to the dictionary.

##### Parameters

-   `key` - The key associated with the value.
-   `value` - The value to add.

---

#### `Remove(System.String)`

Remove item by key from the collection.

##### Parameters

-   `key` - The key that you want to remove.

##### Returns

True if it removed a value from the collection, otherwise false.

---

#### `Remove(UnityAtoms.AtomBaseVariable{System.String})`

Remove item by key from the collection.

##### Parameters

-   `key` - The key that you want to remove.

##### Returns

True if it removed a value from the collection, otherwise false.

---

## `SerializableDictionary<K,V>`

#### Type Parameters

-   `K` - Key type.
-   `V` - Value type.

A Serializable dictionary used by AtomCollection.

### Variables

#### `_duplicateKeyIndices`

Needed in order to keep track of duplicate keys in the dictionary.

---

## `AtomCollection`

A Collection / Dictionary of Atom Variables (AtomBaseVariable).

### Properties

#### `Added`

Event for when and item is added to the collection.

---

#### `Removed`

Event for when and item is removed from the collection.

---

#### `Cleared`

Event for when the collection is cleared.

### Methods

#### `ObserveAdd`

Make the add event into an `IObservable<T>`. Makes Collection's add Event compatible with for example UniRx.

##### Returns

The add Event as an `IObservable<T>`.

---

#### `ObserveRemove`

Make the remove event into an `IObservable<T>`. Makes Collection's remove Event compatible with for example UniRx.

##### Returns

The remove Event as an `IObservable<T>`.

---

#### `ObserveClear`

Make the clear event into an `IObservable<Void>`. Makes Collection's clear Event compatible with for example UniRx.

##### Returns

The clear Event as an `IObservable<Void>`.

---

## `Void`

Dummy module class used for representing nothing in for example empty Events, eg: `AtomEvent<Void>`

---

## `FloatReference`

Reference of type `float`. Inherits from `EquatableAtomReference<float, FloatConstant, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer>`.

---

## `Vector2Reference`

Reference of type `Vector2`. Inherits from `EquatableAtomReference<Vector2, Vector2Constant, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer>`.

---

## `BoolReference`

Reference of type `bool`. Inherits from `EquatableAtomReference<bool, BoolConstant, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer>`.

---

## `ColorReference`

Reference of type `Color`. Inherits from `EquatableAtomReference<Color, ColorConstant, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer>`.

---

## `ColliderReference`

Reference of type `Collider`. Inherits from `AtomReference<Collider, ColliderConstant, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer>`.

---

## `IntReference`

Reference of type `int`. Inherits from `EquatableAtomReference<int, IntConstant, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer>`.

---

## `AtomReferenceBase`

None generic base class for `AtomReference<T, C, V, E1, E2, F, VI>`.

### Variables

#### `_usage`

Descries how we use the Reference and where the value comes from.

---

## `AtomReferenceBase.Usage`

Enum for how to use the Reference.

---

## `Collider2DReference`

Reference of type `Collider2D`. Inherits from `AtomReference<Collider2D, Collider2DConstant, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer>`.

---

## `GameObjectReference`

Reference of type `GameObject`. Inherits from `AtomReference<GameObject, GameObjectConstant, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer>`.

---

## `Vector3Reference`

Reference of type `Vector3`. Inherits from `EquatableAtomReference<Vector3, Vector3Constant, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer>`.

---

## `AtomReference<T,C,V,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the variable.
-   `C` - Constant of type T.
-   `V` - Variable of type T.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T.
-   `VI` - Variable Instancer of type T.

A Reference lets you define a variable in your script where you then from the inspector can choose if it's going to be taking the value from a Constant, Variable, Value or a Variable Instancer.

### Variables

#### `_value`

Value used if `Usage` is set to `Value`.

---

#### `_constant`

Constant used if `Usage` is set to `Constant`.

---

#### `_variable`

Variable used if `Usage` is set to `Variable`.

---

#### `_variableInstancer`

Variable Instancer used if `Usage` is set to `VariableInstancer`.

### Properties

#### `Value`

Get or set the value for the Reference.

---

## `StringReference`

Reference of type `string`. Inherits from `EquatableAtomReference<string, StringConstant, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer>`.

---

## `GameObjectUnityEvent`

None generic Unity Event of type `GameObject`. Inherits from `UnityEvent<GameObject>`.

---

## `Collider2DUnityEvent`

None generic Unity Event of type `Collider2D`. Inherits from `UnityEvent<Collider2D>`.

---

## `ColliderColliderUnityEvent`

None generic Unity Event x 2 of type `Collider`. Inherits from `UnityEvent<Collider, Collider>`.

---

## `ColliderUnityEvent`

None generic Unity Event of type `Collider`. Inherits from `UnityEvent<Collider>`.

---

## `BoolUnityEvent`

None generic Unity Event of type `bool`. Inherits from `UnityEvent<bool>`.

---

## `Collider2DCollider2DUnityEvent`

None generic Unity Event x 2 of type `Collider2D`. Inherits from `UnityEvent<Collider2D, Collider2D>`.

---

## `FloatFloatUnityEvent`

None generic Unity Event x 2 of type `float`. Inherits from `UnityEvent<float, float>`.

---

## `Vector2UnityEvent`

None generic Unity Event of type `Vector2`. Inherits from `UnityEvent<Vector2>`.

---

## `FloatUnityEvent`

None generic Unity Event of type `float`. Inherits from `UnityEvent<float>`.

---

## `StringStringUnityEvent`

None generic Unity Event x 2 of type `string`. Inherits from `UnityEvent<string, string>`.

---

## `IntUnityEvent`

None generic Unity Event of type `int`. Inherits from `UnityEvent<int>`.

---

## `Vector3UnityEvent`

None generic Unity Event of type `Vector3`. Inherits from `UnityEvent<Vector3>`.

---

## `ColorUnityEvent`

None generic Unity Event of type `Color`. Inherits from `UnityEvent<Color>`.

---

## `AtomBaseVariableUnityEvent`

None generic Unity Event of type `AtomBaseVariable`. Inherits from `UnityEvent<AtomBaseVariable>`.

---

## `StringUnityEvent`

None generic Unity Event of type `string`. Inherits from `UnityEvent<string>`.

---

## `Vector2Vector2UnityEvent`

None generic Unity Event x 2 of type `Vector2`. Inherits from `UnityEvent<Vector2, Vector2>`.

---

## `IntIntUnityEvent`

None generic Unity Event x 2 of type `int`. Inherits from `UnityEvent<int, int>`.

---

## `ColorColorUnityEvent`

None generic Unity Event x 2 of type `Color`. Inherits from `UnityEvent<Color, Color>`.

---

## `Vector3Vector3UnityEvent`

None generic Unity Event x 2 of type `Vector3`. Inherits from `UnityEvent<Vector3, Vector3>`.

---

## `GameObjectGameObjectUnityEvent`

None generic Unity Event x 2 of type `GameObject`. Inherits from `UnityEvent<GameObject, GameObject>`.

---

## `BoolBoolUnityEvent`

None generic Unity Event x 2 of type `bool`. Inherits from `UnityEvent<bool, bool>`.

---

## `GameObjectConstant`

Constant of type `GameObject`. Inherits from `AtomBaseVariable<GameObject>`.

---

## `Collider2DConstant`

Constant of type `Collider2D`. Inherits from `AtomBaseVariable<Collider2D>`.

---

## `BoolConstant`

Constant of type `bool`. Inherits from `AtomBaseVariable<bool>`.

---

## `Vector2Constant`

Constant of type `Vector2`. Inherits from `AtomBaseVariable<Vector2>`.

---

## `ColliderConstant`

Constant of type `Collider`. Inherits from `AtomBaseVariable<Collider>`.

---

## `IntConstant`

Constant of type `int`. Inherits from `AtomBaseVariable<int>`.

---

## `FloatConstant`

Constant of type `float`. Inherits from `AtomBaseVariable<float>`.

---

## `StringConstant`

Constant of type `string`. Inherits from `AtomBaseVariable<string>`.

---

## `ColorConstant`

Constant of type `Color`. Inherits from `AtomBaseVariable<Color>`.

---

## `Vector3Constant`

Constant of type `Vector3`. Inherits from `AtomBaseVariable<Vector3>`.

---

## `StringEventReference`

Event Reference of type `string`. Inherits from `AtomEventReference<string, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer>`.

---

## `AtomEventX2Reference<T,V,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the event.
-   `V` - Variable of type T.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T.
-   `VI` - Variable Instancer of type T.

An Event x 2 Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event x 2, Variable or a Variable Instancer.

### Variables

#### `_event`

Event used if `Usage` is set to `Event`.

---

#### `_variable`

Variable used if `Usage` is set to `Variable`.

---

#### `_variableInstancer`

Variable Instancer used if `Usage` is set to `VariableInstancer`.

### Properties

#### `Event`

Get or set the event for the Event Reference.

---

## `GameObjectGameObjectEventReference`

Event x 2 Reference of type `GameObject`. Inherits from `AtomEventX2Reference<GameObject, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer>`.

---

## `IntIntEventReference`

Event x 2 Reference of type `int`. Inherits from `AtomEventX2Reference<int, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer>`.

---

## `IntEventReference`

Event Reference of type `int`. Inherits from `AtomEventReference<int, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer>`.

---

## `ColorColorEventReference`

Event x 2 Reference of type `Color`. Inherits from `AtomEventX2Reference<Color, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer>`.

---

## `Vector2Vector2EventReference`

Event x 2 Reference of type `Vector2`. Inherits from `AtomEventX2Reference<Vector2, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer>`.

---

## `ColliderEventReference`

Event Reference of type `Collider`. Inherits from `AtomEventReference<Collider, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer>`.

---

## `BoolEventReference`

Event Reference of type `bool`. Inherits from `AtomEventReference<bool, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer>`.

---

## `GameObjectEventReference`

Event Reference of type `GameObject`. Inherits from `AtomEventReference<GameObject, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer>`.

---

## `BoolBoolEventReference`

Event x 2 Reference of type `bool`. Inherits from `AtomEventX2Reference<bool, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer>`.

---

## `ColliderColliderEventReference`

Event x 2 Reference of type `Collider`. Inherits from `AtomEventX2Reference<Collider, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer>`.

---

## `Vector2EventReference`

Event Reference of type `Vector2`. Inherits from `AtomEventReference<Vector2, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer>`.

---

## `FloatFloatEventReference`

Event x 2 Reference of type `float`. Inherits from `AtomEventX2Reference<float, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer>`.

---

## `Vector3Vector3EventReference`

Event x 2 Reference of type `Vector3`. Inherits from `AtomEventX2Reference<Vector3, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer>`.

---

## `Collider2DEventReference`

Event Reference of type `Collider2D`. Inherits from `AtomEventReference<Collider2D, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer>`.

---

## `AtomEventReference<T,V,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the event.
-   `V` - Variable of type T.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T.
-   `VI` - Variable Instancer of type T.

An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Variable or a Variable Instancer.

### Variables

#### `_event`

Event used if `Usage` is set to `Event`.

---

#### `_variable`

Variable used if `Usage` is set to `Variable`.

---

#### `_variableInstancer`

Variable Instancer used if `Usage` is set to `VariableInstancer`.

### Properties

#### `Event`

Get or set the event for the Event Reference.

---

## `Vector3EventReference`

Event Reference of type `Vector3`. Inherits from `AtomEventReference<Vector3, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer>`.

---

## `FloatEventReference`

Event Reference of type `float`. Inherits from `AtomEventReference<float, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer>`.

---

## `Collider2DCollider2DEventReference`

Event x 2 Reference of type `Collider2D`. Inherits from `AtomEventX2Reference<Collider2D, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer>`.

---

## `AtomEventReferenceBase`

None generic base class for `AtomEventReference<...>`.

### Variables

#### `_usage`

Descries how we use the Event Reference.

---

## `AtomEventReferenceBase.Usage`

Enum for how to use the Event Reference.

---

## `ColorEventReference`

Event Reference of type `Color`. Inherits from `AtomEventReference<Color, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer>`.

---

## `StringStringEventReference`

Event x 2 Reference of type `string`. Inherits from `AtomEventX2Reference<string, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer>`.

---

## `Vector2VariableInstancer`

Variable Instancer of type `Vector2`. Inherits from `AtomVariableInstancer<Vector2Variable, Vector2, Vector2Event, Vector2Vector2Event, Vector2Vector2Function>`.

---

## `AtomVariableInstancer<V,T,E1,E2,F>`

#### Type Parameters

-   `V` - Variable of type T.
-   `T` - The value type.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T

A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable. This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to react accordingly when a prefab with an associated atom is added or deleted to the scene.

### Variables

#### `_base`

The variable that the in memory copy will be based on when created at runtime.

---

#### `_syncToCollection`

If assigned the in memory copy variable will be added to the collection on Start using the gameObject's instance id as key. The value will also be removed from the collection OnDestroy.

---

#### `_syncToList`

If assigned the in memory copy variable will be added to the list on Start. The value will also be removed from the list OnDestroy.

### Properties

#### `Variable`

Getter for retrieving the in memory runtime variable.

---

#### `Value`

Getter for retrieving the value of the in memory runtime variable.

---

## `Vector3VariableInstancer`

Variable Instancer of type `Vector3`. Inherits from `AtomVariableInstancer<Vector3Variable, Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function>`.

---

## `FloatVariableInstancer`

Variable Instancer of type `float`. Inherits from `AtomVariableInstancer<FloatVariable, float, FloatEvent, FloatFloatEvent, FloatFloatFunction>`.

---

## `BoolVariableInstancer`

Variable Instancer of type `bool`. Inherits from `AtomVariableInstancer<BoolVariable, bool, BoolEvent, BoolBoolEvent, BoolBoolFunction>`.

---

## `Collider2DVariableInstancer`

Variable Instancer of type `Collider2D`. Inherits from `AtomVariableInstancer<Collider2DVariable, Collider2D, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction>`.

---

## `GameObjectVariableInstancer`

Variable Instancer of type `GameObject`. Inherits from `AtomVariableInstancer<GameObjectVariable, GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction>`.

---

## `ColorVariableInstancer`

Variable Instancer of type `Color`. Inherits from `AtomVariableInstancer<ColorVariable, Color, ColorEvent, ColorColorEvent, ColorColorFunction>`.

---

## `ColliderVariableInstancer`

Variable Instancer of type `Collider`. Inherits from `AtomVariableInstancer<ColliderVariable, Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction>`.

---

## `IntVariableInstancer`

Variable Instancer of type `int`. Inherits from `AtomVariableInstancer<IntVariable, int, IntEvent, IntIntEvent, IntIntFunction>`.

---

## `StringVariableInstancer`

Variable Instancer of type `string`. Inherits from `AtomVariableInstancer<StringVariable, string, StringEvent, StringStringEvent, StringStringFunction>`.

---

## `Runtime`

Internal constant and static readonly members for runtime usage.

### Properties

#### `IsUnityAtomsRepo`

Determine if we are working the Unity Atoms source library / repo or not.

---

## `Runtime.Constants`

Runtime constants

### Variables

#### `LOG_PREFIX`

Prefix that should be pre-pended to all Debug.Logs made from UnityAtoms to help immediately inform a user that those logs are made from this library.

---

## `DynamicAtoms`

Static helper class for when creating Atoms a runtime (yes it is indeed possible 🤯).

### Methods

#### `CreateVariable<T,V,E1,E2,F>(initialValue,changed,changedWithHistory,preChangeTransformers)`

Create a Variable at runtime.

#### Type Parameters

-   `T` - The Variable value type.
-   `V` - The Variable type AtomVariable<T, E1, E2>`.
-   `E1` - The type of the `changed` Event of type `AtomEvent<T>`.
-   `E2` - The type of the `changedWithHistory` Event of type `AtomEvent<T, T>`.
-   `F` - The type of the `preChangeTransformers` Functions of type `AtomFunction<T, T>`.

##### Parameters

-   `initialValue` - Inital value of the Variable created.
-   `changed` - Changed Event of type `E1`.
-   `changedWithHistory` - Changed with history Event of type `E2`.
-   `preChangeTransformers` - List of pre change transformers of the type `List<F>`.

##### Returns

The Variable created.

---

#### `CreateList<T,L,E>(added,removed,cleared)`

Create a List at runtime.

#### Type Parameters

-   `T` - The list item type.
-   `L` - The List type to create of type `AtomList<T, E>`.
-   `E` - The Event tyoe used for `removed` and `added` of type `AtomEvent<T>`.

##### Parameters

-   `added` - Added Event of type `E`.
-   `removed` - Removed Event of type `E`.
-   `cleared` - Cleared Event of type `Void`.

##### Returns

The List created.

---

#### `CreateAction<A,T1>(action)`

Create an Action at runtime.

#### Type Parameters

-   `A` - The Action created of type `AtomAction<T>`.
-   `T1` - The type of the first parameter of the Action.

##### Parameters

-   `action` - The action.

##### Returns

The Action created

---

#### `CreateAction<A,T1,T2>(action)`

Create an Action at runtime.

#### Type Parameters

-   `A` - The Action created of type `AtomAction<T1, T2>`.
-   `T1` - The type of the first parameter of the Action.
-   `T2` - The type of the second parameter of the Action.

##### Parameters

-   `action` - The action.

##### Returns

The Action created

---

#### `CreateAction<A,T1,T2,T3>(action)`

Create an Action at runtime.

#### Type Parameters

-   `A` - The Action created of type `AtomAction<T1, T2, T3>`.
-   `T1` - The type of the first parameter of the Action.
-   `T2` - The type of the second parameter of the Action.
-   `T3` - The type of the third parameter of the Action.

##### Parameters

-   `action` - The action.

##### Returns

The Action created

---

#### `CreateAction<A,T1,T2,T3,T4>(action)`

Create an Action at runtime.

#### Type Parameters

-   `A` - The Action created of type `AtomAction<T1, T2, T3, T4>`.
-   `T1` - The type of the first parameter of the Action.
-   `T2` - The type of the second parameter of the Action.
-   `T3` - The type of the third parameter of the Action.
-   `T4` - The type of the fourth parameter of the Action.

##### Parameters

-   `action` - The action.

##### Returns

The Action created

---

#### `CreateAction<A,T1,T2,T3,T4,T5>(action)`

Create an Action at runtime.

#### Type Parameters

-   `A` - The Action created of type `AtomAction<T1, T2, T3, T4, T5>`.
-   `T1` - The type of the first parameter of the Action.
-   `T2` - The type of the second parameter of the Action.
-   `T3` - The type of the third parameter of the Action.
-   `T4` - The type of the fourth parameter of the Action.
-   `T5` - The type of the fifth parameter of the Action.

##### Parameters

-   `action` - The action.

##### Returns

The Action created

---

#### `CreateFunction<F,R>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R>`.
-   `R` - The return type.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

#### `CreateFunction<F,R,T1>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R, T1>`.
-   `R` - The return type.
-   `T1` - The type of the first parameter of the Function.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

#### `CreateFunction<F,R,T1,T2>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R, T1, T2>`.
-   `R` - The return type.
-   `T1` - The type of the first parameter of the Function.
-   `T2` - The type of the second parameter of the Function.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

#### `CreateFunction<F,R,T1,T2,T3>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R, T1, T2, T3>`.
-   `R` - The return type.
-   `T1` - The type of the first parameter of the Function.
-   `T2` - The type of the second parameter of the Function.
-   `T3` - The type of the third parameter of the Function.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

#### `CreateFunction<F,R,T1,T2,T3,T4>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R, T1, T2, T3, T4>`.
-   `R` - The return type.
-   `T1` - The type of the first parameter of the Function.
-   `T2` - The type of the second parameter of the Function.
-   `T3` - The type of the third parameter of the Function.
-   `T4` - The type of the fourth parameter of the Function.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

#### `CreateFunction<F,R,T1,T2,T3,T4,T5>(func)`

Create a Function at runtime.

#### Type Parameters

-   `F` - The Function created of type `AtomFunction<R, T1, T2, T3, T4, T5>`.
-   `R` - The return type.
-   `T1` - The type of the first parameter of the Function.
-   `T2` - The type of the second parameter of the Function.
-   `T3` - The type of the third parameter of the Function.
-   `T4` - The type of the fourth parameter of the Function.
-   `T5` - The type of the fifth parameter of the Function.

##### Parameters

-   `func` - The function.

##### Returns

The Function crated.

---

## `BoolVariable`

Variable of type `bool`. Inherits from `EquatableAtomVariable<bool, BoolEvent, BoolBoolEvent, BoolBoolFunction>`.

---

## `AtomBaseVariable`

None generic base class for Variables. Inherits from `BaseAtom`.

### Properties

#### `BaseValue`

The Variable value as an `object`.abstract Beware of boxing! 🥊

### Methods

#### `Reset(System.Boolean)`

Abstract method that could be implemented to reset the Variable value.

---

## `AtomBaseVariable<T>`

#### Type Parameters

-   `T` - The Variable value type.

Generic base class for Variables. Inherits from `AtomBaseVariable`.

### Properties

#### `BaseValue`

The Variable value as an `object`.abstract Beware of boxing! 🥊

---

#### `Value`

The Variable value as a property.

### Methods

#### `Equals(other)`

Determines equality between Variables.

##### Parameters

-   `other` - The other Variable to compare.

##### Returns

`true` if they are equal, otherwise `false`.

---

#### `Reset(System.Boolean)`

Not implemented.abstract Throws Exception

---

## `Vector2Variable`

Variable of type `Vector2`. Inherits from `EquatableAtomVariable<Vector2, Vector2Event, Vector2Vector2Event, Vector2Vector2Function>`.

### Methods

#### `MultiplyBy(System.Single)`

Multiply variable by value.

##### Parameters

-   `value` - Value to multiple by.

---

#### `MultiplyBy(UnityAtoms.AtomBaseVariable{System.Single})`

Multiply variable by Variable value.

##### Parameters

-   `variable` - Variable with value to multiple by.

---

#### `DivideBy(System.Single)`

Divide Variable by value.

##### Parameters

-   `value` - Value to divide by.

---

#### `DivideBy(UnityAtoms.AtomBaseVariable{System.Single})`

Divide Variable by Variable value.

##### Parameters

-   `variable` - Variable value to divide by.

---

## `ColliderVariable`

Variable of type `Collider`. Inherits from `AtomVariable<Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction>`.

---

## `IntVariable`

Variable of type `int`. Inherits from `EquatableAtomVariable<int, IntEvent, IntIntEvent, IntIntFunction>`.

### Methods

#### `Add(System.Int32)`

Add value to Variable.

##### Parameters

-   `value` - Value to add.

---

#### `Add(UnityAtoms.AtomBaseVariable{System.Int32})`

Add variable value to Variable.

##### Parameters

-   `variable` - Variable with value to add.

---

#### `Subtract(System.Int32)`

Subtract value from Variable.

##### Parameters

-   `value` - Value to subtract.

---

#### `Subtract(UnityAtoms.AtomBaseVariable{System.Int32})`

Subtract variable value from Variable.

##### Parameters

-   `variable` - Variable with value to subtract.

---

#### `MultiplyBy(System.Int32)`

Multiply variable by value.

##### Parameters

-   `value` - Value to multiple by.

---

#### `MultiplyBy(UnityAtoms.AtomBaseVariable{System.Int32})`

Multiply variable by Variable value.

##### Parameters

-   `variable` - Variable with value to multiple by.

---

#### `DivideBy(System.Int32)`

Divide Variable by value.

##### Parameters

-   `value` - Value to divide by.

---

#### `DivideBy(UnityAtoms.AtomBaseVariable{System.Int32})`

Divide Variable by Variable value.

##### Parameters

-   `variable` - Variable value to divide by.

---

## `FloatVariable`

Variable of type `float`. Inherits from `EquatableAtomVariable<float, FloatEvent, FloatFloatEvent, FloatFloatFunction>`.

### Methods

#### `Add(System.Single)`

Add value to Variable.

##### Parameters

-   `value` - Value to add.

---

#### `Add(UnityAtoms.AtomBaseVariable{System.Single})`

Add variable value to Variable.

##### Parameters

-   `variable` - Variable with value to add.

---

#### `Subtract(System.Single)`

Subtract value from Variable.

##### Parameters

-   `value` - Value to subtract.

---

#### `Subtract(UnityAtoms.AtomBaseVariable{System.Single})`

Subtract variable value from Variable.

##### Parameters

-   `variable` - Variable with value to subtract.

---

#### `MultiplyBy(System.Single)`

Multiply variable by value.

##### Parameters

-   `value` - Value to multiple by.

---

#### `MultiplyBy(UnityAtoms.AtomBaseVariable{System.Single})`

Multiply variable by Variable value.

##### Parameters

-   `variable` - Variable with value to multiple by.

---

#### `DivideBy(System.Single)`

Divide Variable by value.

##### Parameters

-   `value` - Value to divide by.

---

#### `DivideBy(UnityAtoms.AtomBaseVariable{System.Single})`

Divide Variable by Variable value.

##### Parameters

-   `variable` - Variable value to divide by.

---

## `StringVariable`

Variable of type `string`. Inherits from `EquatableAtomVariable<string, StringEvent, StringStringEvent, StringStringFunction>`.

---

## `AtomVariable<T,E1,E2,F>`

#### Type Parameters

-   `T` - The Variable value type.
-   `E1` - Event of type `AtomEvent<T>`.
-   `E2` - Event of type `AtomEvent<T, T>`.
-   `F` - Function of type `FunctionEvent<T, T>`.

Generic base class for Variables. Inherits from `AtomBaseVariable<T>`.

### Variables

#### `_initialValue`

The inital value of the Variable.

---

#### `Changed`

Changed Event triggered when the Variable value gets changed.

---

#### `ChangedWithHistory`

Changed with history Event triggered when the Variable value gets changed.

### Properties

#### `Value`

The Variable value as a property.

---

#### `InitialValue`

The inital Variable value as a property.

---

#### `OldValue`

The value the Variable had before its value got changed last time.

---

#### `PreChangeTransformers`

When setting the value of a Variable the new value will be piped through all the pre change transformers, which allows you to create custom logic and restriction on for example what values can be set for this Variable.

### Methods

#### `Reset(System.Boolean)`

Reset the Variable to its `_initalValue`.

##### Parameters

-   `shouldTriggerEvents` - Set to `true` if Events should be triggered on reset, otherwise `false`.

---

#### `SetValue(newValue)`

Set the Variable value.

##### Parameters

-   `newValue` - The new value to set.

##### Returns

`true` if the value got changed, otherwise `false`.

---

#### `SetValue(variable)`

Set the Variable value.

##### Parameters

-   `variable` - The value to set provided from another Variable.

##### Returns

`true` if the value got changed, otherwise `false`.

---

#### `ObserveChange`

Turn the Variable's change Event into an `IObservable<T>`. Makes the Variable's change Event compatible with for example UniRx.

##### Returns

The Variable's change Event as an `IObservable<T>`.

---

#### `ObserveChangeWithHistory`

Turn the Variable's change with history Event into an `IObservable<T, T>`. Makes the Variable's change with history Event compatible with for example UniRx.

##### Returns

The Variable's change Event as an `IObservable<T, T>`.

---

## `GameObjectVariable`

Variable of type `GameObject`. Inherits from `AtomVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction>`.

---

## `Collider2DVariable`

Variable of type `Collider2D`. Inherits from `AtomVariable<Collider2D, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction>`.

---

## `ColorVariable`

Variable of type `Color`. Inherits from `EquatableAtomVariable<Color, ColorEvent, ColorColorEvent, ColorColorFunction>`.

### Methods

#### `SetAlpha(System.Single)`

Set Alpha of Color by value.

##### Parameters

-   `value` - New alpha value.

---

#### `SetAlpha(UnityAtoms.AtomBaseVariable{System.Single})`

Set Alpha of Color by Variable value.

##### Parameters

-   `variable` - New alpha Variable value.

---

## `Vector3Variable`

Variable of type `Vector3`. Inherits from `EquatableAtomVariable<Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function>`.

### Methods

#### `MultiplyBy(System.Single)`

Multiply variable by value.

##### Parameters

-   `value` - Value to multiple by.

---

#### `MultiplyBy(UnityAtoms.AtomBaseVariable{System.Single})`

Multiply variable by Variable value.

##### Parameters

-   `variable` - Variable with value to multiple by.

---

#### `DivideBy(System.Single)`

Divide Variable by value.

##### Parameters

-   `value` - Value to divide by.

---

#### `DivideBy(UnityAtoms.AtomBaseVariable{System.Single})`

Divide Variable by Variable value.

##### Parameters

-   `variable` - Variable value to divide by.

---

## `AtomList`

A List of Atom Variables (AtomBaseVariable).

### Properties

#### `Added`

Event for when and item is added to the list.

---

#### `Removed`

Event for when and item is removed from the list.

---

#### `Cleared`

Event for when the list is cleared.

### Methods

#### `ObserveAdd`

Make the add event into an `IObservable<T>`. Makes List's add Event compatible with for example UniRx.

##### Returns

The add Event as an `IObservable<T>`.

---

#### `ObserveRemove`

Make the remove event into an `IObservable<T>`. Makes List's remove Event compatible with for example UniRx.

##### Returns

The remove Event as an `IObservable<T>`.

---

#### `ObserveClear`

Make the clear event into an `IObservable<Void>`. Makes List's clear Event compatible with for example UniRx.

##### Returns

The clear Event as an `IObservable<Void>`.

---

## `AtomBaseVariableList`

A List of type AtomBaseVariable. Used by AtomList.

### Methods

#### `Get<T>(System.Int32)`

Generic getter.

#### Type Parameters

-   `T` - The expected type of the value you want to retrieve.

##### Parameters

-   `index` - The index you want to retrieve.

##### Returns

The value of type T at specified index.

---

#### `Get<T>(UnityAtoms.AtomBaseVariable{System.Int32})`

Generic getter.

#### Type Parameters

-   `T` - The expected type of the value you want to retrieve.

##### Parameters

-   `index` - The index you want to retrieve.

##### Returns

The value of type T at specified index.

---

#### `Add(UnityAtoms.AtomBaseVariable)`

Add an item to the list.

##### Parameters

-   `item` - The item to add.

---

#### `Remove(UnityAtoms.AtomBaseVariable)`

Remove an item from the list.

##### Parameters

-   `item` - The item to remove.

##### Returns

True if it was removed, otherwise false..

---

#### `RemoveAt(System.Int32)`

Remove an item at provided index.

##### Parameters

-   `index` - The index to remove item at.

---

#### `Insert(System.Int32,UnityAtoms.AtomBaseVariable)`

Insert item at index.

##### Parameters

-   `index` - Index to insert item at.
-   `item` - Item to insert.

---

#### `Clear`

Ckear list.

---

## `AtomBaseVariableAction`

Action of type `AtomBaseVariable`. Inherits from `AtomAction<AtomBaseVariable>`.

---

## `AtomAction`

Base abstract class for Actions. Inherits from `BaseAtom`.

### Variables

#### `ActionNoValue`

The actual Action.

### Methods

#### `Do`

Perform the Action.

---

## `AtomAction<T1>`

#### Type Parameters

-   `T1` - The type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Variables

#### `Action`

The actual Action.

### Methods

#### `Do(t1)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.

---

## `AtomAction<T1,T2>`

#### Type Parameters

-   `T1` - The first type for this Action.
-   `T2` - The second type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Variables

#### `Action`

The actual Action.

### Methods

#### `Do(t1,t2)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.

---

## `AtomAction<T1,T2,T3>`

#### Type Parameters

-   `T1` - The first type for this Action.
-   `T2` - The second type for this Action.
-   `T3` - The third type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Variables

#### `Action`

The actual Action.

### Methods

#### `Do(t1,t2,t3)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.

---

## `AtomAction<T1,T2,T3,T4>`

#### Type Parameters

-   `T1` - The first type for this Action.
-   `T2` - The second type for this Action.
-   `T3` - The third type for this Action.
-   `T4` - The fourth type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Variables

#### `Action`

The actual Action.

### Methods

#### `Do(t1,t2,t3,t4)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.
-   `t4` - The fourth parameter.

---

## `AtomAction<T1,T2,T3,T4,T5>`

#### Type Parameters

-   `T1` - The first type for this Action.
-   `T2` - The second type for this Action.
-   `T3` - The third type for this Action.
-   `T4` - The fourth type for this Action.
-   `T5` - The fifth type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Variables

#### `Action`

The actual Action.

### Methods

#### `Do(t1,t2,t3,t4,t5)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.
-   `t4` - The fourth parameter.
-   `t5` - The fifth parameter.

---

## `StringStringAction`

Action x 2 of type `string`. Inherits from `AtomAction<string, string>`.

---

## `GameObjectAction`

Action of type `GameObject`. Inherits from `AtomAction<GameObject>`.

---

## `FloatFloatAction`

Action x 2 of type `float`. Inherits from `AtomAction<float, float>`.

---

## `Vector2Action`

Action of type `Vector2`. Inherits from `AtomAction<Vector2>`.

---

## `Vector3Action`

Action of type `Vector3`. Inherits from `AtomAction<Vector3>`.

---

## `VoidAction`

Action of type `Void`. Inherits from `AtomAction<Void>`.

### Methods

#### `Do(UnityAtoms.Void)`

Do the Action.

##### Parameters

-   `_` - Dummy Void parameter.

---

## `ColorAction`

Action of type `Color`. Inherits from `AtomAction<Color>`.

---

## `IntIntAction`

Action x 2 of type `int`. Inherits from `AtomAction<int, int>`.

---

## `BoolBoolAction`

Action x 2 of type `bool`. Inherits from `AtomAction<bool, bool>`.

---

## `ColliderAction`

Action of type `Collider`. Inherits from `AtomAction<Collider>`.

---

## `StringAction`

Action of type `string`. Inherits from `AtomAction<string>`.

---

## `ColorColorAction`

Action x 2 of type `Color`. Inherits from `AtomAction<Color, Color>`.

---

## `BoolAction`

Action of type `bool`. Inherits from `AtomAction<bool>`.

---

## `Vector3Vector3Action`

Action x 2 of type `Vector3`. Inherits from `AtomAction<Vector3, Vector3>`.

---

## `IntAction`

Action of type `int`. Inherits from `AtomAction<int>`.

---

## `FloatAction`

Action of type `float`. Inherits from `AtomAction<float>`.

---

## `Collider2DCollider2DAction`

Action x 2 of type `Collider2D`. Inherits from `AtomAction<Collider2D, Collider2D>`.

---

## `Collider2DAction`

Action of type `Collider2D`. Inherits from `AtomAction<Collider2D>`.

---

## `ColliderColliderAction`

Action x 2 of type `Collider`. Inherits from `AtomAction<Collider, Collider>`.

---

## `GameObjectGameObjectAction`

Action x 2 of type `GameObject`. Inherits from `AtomAction<GameObject, GameObject>`.

---

## `Vector2Vector2Action`

Action x 2 of type `Vector2`. Inherits from `AtomAction<Vector2, Vector2>`.

---

## `FloatFloatFunction`

Function x 2 of type `float`. Inherits from `AtomFunction<float, float>`.

---

## `Vector3Vector3Function`

Function x 2 of type `Vector3`. Inherits from `AtomFunction<Vector3, Vector3>`.

---

## `AtomFunction<R>`

#### Type Parameters

-   `R` - The type to return from the Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call`

Call the Function.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<R>`.

##### Parameters

-   `func` - The `Func<R>` to set.

##### Returns

An `AtomFunction<R>`.

---

## `AtomFunction<R,T1>`

#### Type Parameters

-   `R` - The type to return from the Function.
-   `T1` - The parameter type for this Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call(t1)`

Call the Function.

##### Parameters

-   `t1` - The first parameter.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<T1, R>`.

##### Parameters

-   `func` - The `Func<T1, R>` to set.

##### Returns

An `AtomFunction<R, T1>`.

---

## `AtomFunction<R,T1,T2>`

#### Type Parameters

-   `R` - The type to return from the Function.
-   `T1` - The first parameter type for this Function.
-   `T2` - The second parameter type for this Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call(t1,t2)`

Call the Function.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<T1, T2, R>`.

##### Parameters

-   `func` - The `Func<T1, T2, R>` to set.

##### Returns

An `AtomFunction<R, T1, T2>`.

---

## `AtomFunction<R,T1,T2,T3>`

#### Type Parameters

-   `R` - The type to return from the Function.
-   `T1` - The first parameter type for this Function.
-   `T2` - The second parameter type for this Function.
-   `T3` - The third parameter type for this Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call(t1,t2,t3)`

Call the Function.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<T1, T2, T3, R>`.

##### Parameters

-   `func` - The `Func<T1, T2, T3, R>` to set.

##### Returns

An `AtomFunction<R, T1, T2, T3>`.

---

## `AtomFunction<R,T1,T2,T3,T4>`

#### Type Parameters

-   `R` - The type to return from the Function.
-   `T1` - The first parameter type for this Function.
-   `T2` - The second parameter type for this Function.
-   `T3` - The third parameter type for this Function.
-   `T4` - The fourth parameter type for this Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call(t1,t2,t3,t4)`

Call the Function.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.
-   `t4` - The fourth parameter.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<T1, T2, T3, T4 R>`.

##### Parameters

-   `func` - The `Func<T1, T2, T3, T4, R>` to set.

##### Returns

An `AtomFunction<R, T1, T2, T3, T4>`.

---

## `AtomFunction<R,T1,T2,T3,T4,T5>`

#### Type Parameters

-   `R` - The type to return from the Function.
-   `T1` - The first parameter type for this Function.
-   `T2` - The second parameter type for this Function.
-   `T3` - The third parameter type for this Function.
-   `T4` - The fourth parameter type for this Function.
-   `T5` - The fifth parameter type for this Function.

Generic abstract base class for Functions. Inherits from `BaseAtom`.

### Variables

#### `Func`

The actual function.

### Methods

#### `Call(t1,t2,t3,t4,t5)`

Call the Function.

##### Parameters

-   `t1` - The first parameter.
-   `t2` - The second parameter.
-   `t3` - The third parameter.
-   `t4` - The fourth parameter.
-   `t5` - The fifth parameter.

##### Returns

Whatever the function decides to return of type `R`.

---

#### `SetFunc(func)`

Set the Function providing a `Func<T1, T2, T3, T4, T5 R>`.

##### Parameters

-   `func` - The `Func<T1, T2, T3, T4, T5, R>` to set.

##### Returns

An `AtomFunction<R, T1, T2, T3, T4, T5>`.

---

## `IntIntFunction`

Function x 2 of type `int`. Inherits from `AtomFunction<int, int>`.

---

## `BoolBoolFunction`

Function x 2 of type `bool`. Inherits from `AtomFunction<bool, bool>`.

---

## `Collider2DCollider2DFunction`

Function x 2 of type `Collider2D`. Inherits from `AtomFunction<Collider2D, Collider2D>`.

---

## `Vector2Vector2Function`

Function x 2 of type `Vector2`. Inherits from `AtomFunction<Vector2, Vector2>`.

---

## `GameObjectGameObjectFunction`

Function x 2 of type `GameObject`. Inherits from `AtomFunction<GameObject, GameObject>`.

---

## `StringStringFunction`

Function x 2 of type `string`. Inherits from `AtomFunction<string, string>`.

---

## `ColorColorFunction`

Function x 2 of type `Color`. Inherits from `AtomFunction<Color, Color>`.

---

## `ColliderColliderFunction`

Function x 2 of type `Collider`. Inherits from `AtomFunction<Collider, Collider>`.

---

## `Collider2DCollider2DEvent`

Event x 2 of type `Collider2D`. Inherits from `AtomEvent<Collider2D, Collider2D>`.

---

## `BoolBoolEvent`

Event x 2 of type `bool`. Inherits from `AtomEvent<bool, bool>`.

---

## `IntIntEvent`

Event x 2 of type `int`. Inherits from `AtomEvent<int, int>`.

---

## `StringStringEvent`

Event x 2 of type `string`. Inherits from `AtomEvent<string, string>`.

---

## `AtomEventBase`

None generic base class for Events. Inherits from `BaseAtom` and `ISerializationCallbackReceiver`.

### Methods

#### `Register(System.Action)`

Register handler to be called when the Event triggers.

##### Parameters

-   `del` - The handler.

---

#### `Unregister(System.Action)`

Unregister handler that was registered using the `Register` method.

##### Parameters

-   `del` - The handler.

---

#### `RegisterListener(UnityAtoms.IAtomListener)`

Register a Listener that in turn trigger all its associated handlers when the Event triggers.

##### Parameters

-   `listener` - The Listener to register.

---

#### `UnregisterListener(UnityAtoms.IAtomListener)`

Unregister a listener that was registered using the `RegisterListener` method.

##### Parameters

-   `listener` - The Listener to unregister.

---

## `ColliderEvent`

Event of type `Collider`. Inherits from `AtomEvent<Collider>`.

---

## `ColorColorEvent`

Event x 2 of type `Color`. Inherits from `AtomEvent<Color, Color>`.

---

## `GameObjectEvent`

Event of type `GameObject`. Inherits from `AtomEvent<GameObject>`.

---

## `ColliderColliderEvent`

Event x 2 of type `Collider`. Inherits from `AtomEvent<Collider, Collider>`.

---

## `Vector2Vector2Event`

Event x 2 of type `Vector2`. Inherits from `AtomEvent<Vector2, Vector2>`.

---

## `Vector3Vector3Event`

Event x 2 of type `Vector3`. Inherits from `AtomEvent<Vector3, Vector3>`.

---

## `AtomEvent<T>`

#### Type Parameters

-   `T` - The type for this Event.

Generic base class for Events. Inherits from `AtomEventBase`.

### Variables

#### `_replayBufferSize`

The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx.

---

#### `_raiseValue`

Used when raising values from the inspector for debugging purposes.

### Methods

#### `Raise(item)`

Raise the Event.

##### Parameters

-   `item` - The value associated with the Event.

---

#### `Register(action)`

Register handler to be called when the Event triggers.

##### Parameters

-   `action` - The handler.

---

#### `Unregister(action)`

Unregister handler that was registered using the `Register` method.

##### Parameters

-   `action` - The handler.

---

#### `RegisterListener(listener)`

Register a Listener that in turn trigger all its associated handlers when the Event triggers.

##### Parameters

-   `listener` - The Listener to register.

---

#### `UnregisterListener(listener)`

Unregister a listener that was registered using the `RegisterListener` method.

##### Parameters

-   `listener` - The Listener to unregister.

---

#### `Observe`

Turn the Event into an `IObservable<T>`. Makes Events compatible with for example UniRx.

##### Returns

The Event as an `IObservable<T>`.

---

## `AtomEvent<T1,T2>`

#### Type Parameters

-   `T1` - The first type for this Event.
-   `T2` - The second type for this Event.

Generic base class for Events. Inherits from `AtomEventBase`.

### Variables

#### `_replayBufferSize`

The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx.

---

#### `_raiseValue1`

Used when raising values from the inspector for debugging purposes.

---

#### `_raiseValue2`

Used when raising values from the inspector for debugging purposes.

### Methods

#### `Raise(item1,item2)`

Raise the Event.

##### Parameters

-   `item1` - The first value associated with the Event.
-   `item2` - The second value associated with the Event.

---

#### `Register(action)`

Register handler to be called when the Event triggers.

##### Parameters

-   `action` - The handler.

---

#### `Unregister(action)`

Unregister handler that was registered using the `Register` method.

##### Parameters

-   `action` - The handler.

---

#### `RegisterListener(listener)`

Register a Listener that in turn trigger all its associated handlers when the Event triggers.

##### Parameters

-   `listener` - The Listener to register.

---

#### `UnregisterListener(listener)`

Unregister a listener that was registered using the `RegisterListener` method.

##### Parameters

-   `listener` - The Listener to unregister.

---

#### `Observe<M>(resultSelector)`

Turn the Event into an `IObservable<M>`. Makes Events compatible with for example UniRx.

#### Type Parameters

-   `M` - The result selector type.

##### Parameters

-   `resultSelector` - Takes `T1` and `T2` and returns a new type of type `M`.abstract Most of the time this is going to be combination of T1 and T2, eg. `ValueTuple<T1, T2>`

##### Returns

The Event as an `IObservable<M>`.

---

## `Vector3Event`

Event of type `Vector3`. Inherits from `AtomEvent<Vector3>`.

---

## `BoolEvent`

Event of type `bool`. Inherits from `AtomEvent<bool>`.

---

## `GameObjectGameObjectEvent`

Event x 2 of type `GameObject`. Inherits from `AtomEvent<GameObject, GameObject>`.

---

## `StringEvent`

Event of type `string`. Inherits from `AtomEvent<string>`.

---

## `AtomBaseVariableEvent`

Event of type `AtomBaseVariable`. Inherits from `AtomEvent<AtomBaseVariable>`.

---

## `ColorEvent`

Event of type `Color`. Inherits from `AtomEvent<Color>`.

---

## `VoidEvent`

Event of type `Void`. Inherits from `AtomEvent<Void>`.

---

## `Vector2Event`

Event of type `Vector2`. Inherits from `AtomEvent<Vector2>`.

---

## `FloatEvent`

Event of type `float`. Inherits from `AtomEvent<float>`.

---

## `FloatFloatEvent`

Event x 2 of type `float`. Inherits from `AtomEvent<float, float>`.

---

## `Collider2DEvent`

Event of type `Collider2D`. Inherits from `AtomEvent<Collider2D>`.

---

## `IntEvent`

Event of type `int`. Inherits from `AtomEvent<int>`.

---

## `FloatFloatListener`

Listener x 2 of type `float`. Inherits from `AtomX2Listener<float, FloatFloatAction, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer, FloatFloatEventReference, FloatFloatUnityEvent>`.

---

## `Collider2DListener`

Listener of type `Collider2D`. Inherits from `AtomListener<Collider2D, Collider2DAction, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer, Collider2DEventReference, Collider2DUnityEvent>`.

---

## `Vector3Vector3Listener`

Listener x 2 of type `Vector3`. Inherits from `AtomX2Listener<Vector3, Vector3Vector3Action, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer, Vector3Vector3EventReference, Vector3Vector3UnityEvent>`.

---

## `GameObjectListener`

Listener of type `GameObject`. Inherits from `AtomListener<GameObject, GameObjectAction, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer, GameObjectEventReference, GameObjectUnityEvent>`.

---

## `AtomListener<T,A,V,E1,E2,F,VI,ER,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `A` - Acion of type T.
-   `V` - Variable of type T.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T.
-   `VI` - Variable Instancer of type T.
-   `ER` - Event Reference of type T.
-   `UER` - UnityEvent of type T.

Generic base class for Listeners. Inherits from `AtomBaseListener` and implements `IAtomListener<T>`.

### Variables

#### `_eventReference`

The Event Reference that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses. NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).

---

#### `_actionResponses`

The Action responses;

### Properties

#### `EventReference`

The Event we are listening for as a property.

### Methods

#### `OnEventRaised(item)`

Handler for when the Event gets raised.

##### Parameters

-   `item` - The Event type.

---

#### `DebugLog(`0)`

Helper to regiser as listener callback

---

## `StringListener`

Listener of type `string`. Inherits from `AtomListener<string, StringAction, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer, StringEventReference, StringUnityEvent>`.

---

## `BoolBoolListener`

Listener x 2 of type `bool`. Inherits from `AtomX2Listener<bool, BoolBoolAction, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer, BoolBoolEventReference, BoolBoolUnityEvent>`.

---

## `FloatListener`

Listener of type `float`. Inherits from `AtomListener<float, FloatAction, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer, FloatEventReference, FloatUnityEvent>`.

---

## `IntIntListener`

Listener x 2 of type `int`. Inherits from `AtomX2Listener<int, IntIntAction, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer, IntIntEventReference, IntIntUnityEvent>`.

---

## `ColliderListener`

Listener of type `Collider`. Inherits from `AtomListener<Collider, ColliderAction, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer, ColliderEventReference, ColliderUnityEvent>`.

---

## `IntListener`

Listener of type `int`. Inherits from `AtomListener<int, IntAction, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer, IntEventReference, IntUnityEvent>`.

---

## `Collider2DCollider2DListener`

Listener x 2 of type `Collider2D`. Inherits from `AtomX2Listener<Collider2D, Collider2DCollider2DAction, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer, Collider2DCollider2DEventReference, Collider2DCollider2DUnityEvent>`.

---

## `Vector2Listener`

Listener of type `Vector2`. Inherits from `AtomListener<Vector2, Vector2Action, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer, Vector2EventReference, Vector2UnityEvent>`.

---

## `AtomBaseListener`

None generic base class for all Listeners.

### Variables

#### `_developerDescription`

A description of the Listener made for documentation purposes.

---

## `BoolListener`

Listener of type `bool`. Inherits from `AtomListener<bool, BoolAction, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer, BoolEventReference, BoolUnityEvent>`.

---

## `Vector2Vector2Listener`

Listener x 2 of type `Vector2`. Inherits from `AtomX2Listener<Vector2, Vector2Vector2Action, Vector2Variable, Vector2Event, Vector2Vector2Event, Vector2Vector2Function, Vector2VariableInstancer, Vector2Vector2EventReference, Vector2Vector2UnityEvent>`.

---

## `AtomBaseVariableListener`

A listener of type `BaseAtomVariable`.

### Variables

#### `_event`

The Event that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses. NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).

---

#### `_actionResponses`

The Action responses;

### Properties

#### `Event`

The Event we are listening for as a property.

### Methods

#### `OnEventRaised(UnityAtoms.AtomBaseVariable)`

Handler for when the Event gets raised.

##### Parameters

-   `item` - The Event type.

---

#### `DebugLog(UnityAtoms.AtomBaseVariable)`

Helper to regiser as listener callback

---

## `GameObjectGameObjectListener`

Listener x 2 of type `GameObject`. Inherits from `AtomX2Listener<GameObject, GameObjectGameObjectAction, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer, GameObjectGameObjectEventReference, GameObjectGameObjectUnityEvent>`.

---

## `Vector3Listener`

Listener of type `Vector3`. Inherits from `AtomListener<Vector3, Vector3Action, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer, Vector3EventReference, Vector3UnityEvent>`.

---

## `AtomX2Listener<T,A,V,E1,E2,F,VI,E2R,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `A` - Acion of type T.
-   `V` - Variable of type T.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T.
-   `VI` - Variable Instancer of type T.
-   `E2R` - Event x 2 Reference of type T.
-   `UER` - UnityEvent of type T.

Generic base class for X2 Listeners. Inherits from `AtomBaseListener` and implements `IAtomListener<T>`.

### Variables

#### `_eventReference`

The Event Reference that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses. NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).

---

#### `_actionResponses`

The Action responses;

### Properties

#### `EventReference`

The Event we are listening for as a property.

### Methods

#### `OnEventRaised(first,second)`

Handler for when the Event gets raised.

##### Parameters

-   `first` - The first Event type.
-   `second` - The second Event type.

---

#### `DebugLog(`0,`0)`

Helper to regiser as listener callback

---

## `StringStringListener`

Listener x 2 of type `string`. Inherits from `AtomX2Listener<string, StringStringAction, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer, StringStringEventReference, StringStringUnityEvent>`.

---

## `ColorColorListener`

Listener x 2 of type `Color`. Inherits from `AtomX2Listener<Color, ColorColorAction, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer, ColorColorEventReference, ColorColorUnityEvent>`.

---

## `VoidListener`

The most basic Listener. Can use every type of AtomEvent but doesn't support its value. Inherits from `AtomBaseListener` and implements `IAtomListener`.

### Variables

#### `_event`

The Event that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses. NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).

---

#### `_actionResponses`

The Action responses;

### Properties

#### `Event`

The Event we are listening for as a property.

### Methods

#### `OnEventRaised`

Handler for when the Event gets raised.

---

## `ColliderColliderListener`

Listener x 2 of type `Collider`. Inherits from `AtomX2Listener<Collider, ColliderColliderAction, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer, ColliderColliderEventReference, ColliderColliderUnityEvent>`.

---

## `ColorListener`

Listener of type `Color`. Inherits from `AtomListener<Color, ColorAction, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer, ColorEventReference, ColorUnityEvent>`.

---

## `BaseAtom`

None generic base class for all Atoms.

### Variables

#### `_developerDescription`

A description of the Atom made for documentation purposes.

---

## `FloatValueList`

Value List of type `float`. Inherits from `AtomValueList<float, FloatEvent>`.

---

## `Vector2ValueList`

Value List of type `Vector2`. Inherits from `AtomValueList<Vector2, Vector2Event>`.

---

## `BoolValueList`

Value List of type `bool`. Inherits from `AtomValueList<bool, BoolEvent>`.

---

## `ColorValueList`

Value List of type `Color`. Inherits from `AtomValueList<Color, ColorEvent>`.

---

## `ColliderValueList`

Value List of type `Collider`. Inherits from `AtomValueList<Collider, ColliderEvent>`.

---

## `IntValueList`

Value List of type `int`. Inherits from `AtomValueList<int, IntEvent>`.

---

## `GameObjectValueList`

Value List of type `GameObject`. Inherits from `AtomValueList<GameObject, GameObjectEvent>`.

---

## `Collider2DValueList`

Value List of type `Collider2D`. Inherits from `AtomValueList<Collider2D, Collider2DEvent>`.

---

## `Vector3ValueList`

Value List of type `Vector3`. Inherits from `AtomValueList<Vector3, Vector3Event>`.

---

## `AtomValueList<T,E>`

#### Type Parameters

-   `T` - The list item type.
-   `E` - Event of type `AtomEvent<T>`.

Generic base class for Lists. Inherits from `BaseAtomList` and `IList<T>`.

### Variables

#### `Added`

Event for when something is added to the list.

---

#### `Removed`

Event for when something is removed from the list.

---

#### `list`

Actual `List<T>`.

### Properties

#### `Count`

Get the count of the list.

---

#### `IsReadOnly`

Is the list read only?

---

#### `List`

The actual `List<T>` as a property.

---

#### `Item(System.Int32)`

Indexer of the list.

### Methods

#### `Add(item)`

Add an item to the list.

##### Parameters

-   `item` - The item to add.

---

#### `Remove(item)`

Remove an item from the list.

##### Parameters

-   `item` - The item to remove.

##### Returns

True if it was removed, otherwise false..

---

#### `Contains(item)`

Does the list contain the item provided?

##### Parameters

-   `item` - The item to check if it is contained in the list.

##### Returns

`true` if the item exists in the list, otherwise `false`.

---

#### `Get(System.Int32)`

Get item at index.

##### Parameters

-   `i` - The index.

##### Returns

The item if it exists.

---

#### `CopyTo(array,arrayIndex)`

Copies the entire List to a compatible one-dimensional array, starting at the specified index of the target array.

##### Parameters

-   `array` - The one-dimensional Array that is the destination of the elements copied from List. The Array must have zero-based indexing.
-   `arrayIndex` - The zero-based index in `array` at which copying begins.

---

#### `GetEnumerator`

Get an `IEnumerator<T>` of the list.

##### Returns

An `IEnumerator<T>`

---

#### `IndexOf(item)`

Returns the index of the specified item.

##### Parameters

-   `item` - The item to search for.

##### Returns

The zero-based index of the first occurrence of `item`. If not found it returns -1.

---

#### `RemoveAt(System.Int32)`

Remove an item at provided index.

##### Parameters

-   `index` - The index to remove item at.

---

#### `Insert(index,item)`

Insert item at index.

##### Parameters

-   `index` - Index to insert item at.
-   `item` - Item to insert.

---

#### `ObserveAdd`

Make the add event into an `IObservable<T>`. Makes Value List's add Event compatible with for example UniRx.

##### Returns

The add Event as an `IObservable<T>`.

---

#### `ObserveRemove`

Make the remove event into an `IObservable<T>`. Makes Value List's remove Event compatible with for example UniRx.

##### Returns

The remove Event as an `IObservable<T>`.

---

#### `ObserveClear`

Make the clear event into an `IObservable<Void>`. Makes Value List's clear Event compatible with for example UniRx.

##### Returns

The clear Event as an `IObservable<Void>`.

---

## `StringValueList`

Value List of type `string`. Inherits from `AtomValueList<string, StringEvent>`.

---

## `BaseAtomValueList`

None generic base class of Lists. Inherits from `BaseAtom`.

### Variables

#### `Cleared`

Event for when the list is cleared.

### Methods

#### `Clear`

Clear the list.

---

## `StringExtensions`

Internal extension class for strings.

### Methods

#### `ToInt(System.String,System.Int32)`

Tries to parse a string to an int.

##### Parameters

-   `str` - The string to parse.
-   `def` - The default value if not able to parse the provided string.

##### Returns

Returns the string parsed to an int. If not able to parse the string, it returns the default value provided to the method.

---

#### `Repeat(System.String,System.Int32)`

Repeats the string X amount of times.

##### Parameters

-   `str` - The string to repeat.
-   `times` - The number of times to repeat the provided string.

##### Returns

The string repeated X amount of times.

---

## `EditorIcon`

Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.

---

## `SetVector2VariableValue`

Set variable value Action of type `Vector2`. Inherits from `SetVariableValue<Vector2, Vector2Variable, Vector2Constant, Vector2Reference, Vector2Event, Vector2Vector2Event, Vector2VariableInstancer>`.

---

## `SetColorVariableValue`

Set variable value Action of type `Color`. Inherits from `SetVariableValue<Color, ColorVariable, ColorConstant, ColorReference, ColorEvent, ColorColorEvent, ColorVariableInstancer>`.

---

## `SetCollider2DVariableValue`

Set variable value Action of type `Collider2D`. Inherits from `SetVariableValue<Collider2D, Collider2DVariable, Collider2DConstant, Collider2DReference, Collider2DEvent, Collider2DCollider2DEvent, Collider2DVariableInstancer>`.

---

## `SetBoolVariableValue`

Set variable value Action of type `bool`. Inherits from `SetVariableValue<bool, BoolVariable, BoolConstant, BoolReference, BoolEvent, BoolBoolEvent, BoolVariableInstancer>`.

---

## `SetFloatVariableValue`

Set variable value Action of type `float`. Inherits from `SetVariableValue<float, FloatVariable, FloatConstant, FloatReference, FloatEvent, FloatFloatEvent, FloatVariableInstancer>`.

---

## `SetVector3VariableValue`

Set variable value Action of type `Vector3`. Inherits from `SetVariableValue<Vector3, Vector3Variable, Vector3Constant, Vector3Reference, Vector3Event, Vector3Vector3Event, Vector3VariableInstancer>`.

---

## `SetVariableValue<T,V,C,R,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the Variable to set.
-   `V` - A Variable class of type `type` to set.
-   `C` - A Constant class of type `type` to set.
-   `R` - A Reference of type `type`.
-   `E1` - An Event of type `type`.
-   `E2` - An Event x 2 of type `type`.
-   `F` - A Function x 2 of type `type`.
-   `VI` - A Variable Instancer of type `type`.

Base class for all SetVariableValue Actions. Inherits from `VoidAction`.

### Variables

#### `_variable`

The Variable to set.

---

#### `_value`

The value to set.

### Methods

#### `Do`

Perform the action.

---

## `SetGameObjectVariableValue`

Set variable value Action of type `GameObject`. Inherits from `SetVariableValue<GameObject, GameObjectVariable, GameObjectConstant, GameObjectReference, GameObjectEvent, GameObjectGameObjectEvent, GameObjectVariableInstancer>`.

---

## `SetStringVariableValue`

Set variable value Action of type `string`. Inherits from `SetVariableValue<string, StringVariable, StringConstant, StringReference, StringEvent, StringStringEvent, StringVariableInstancer>`.

---

## `SetIntVariableValue`

Set variable value Action of type `int`. Inherits from `SetVariableValue<int, IntVariable, IntConstant, IntReference, IntEvent, IntIntEvent, IntVariableInstancer>`.

---

## `SetColliderVariableValue`

Set variable value Action of type `Collider`. Inherits from `SetVariableValue<Collider, ColliderVariable, ColliderConstant, ColliderReference, ColliderEvent, ColliderColliderEvent, ColliderVariableInstancer>`.

---

## `ClampInt`

An `AtomFunction<int, int>` that clamps the value using a min and a max value and returns it.

### Variables

#### `Min`

The minimum value.

---

#### `Max`

The maximum value.

---

## `ClampFloat`

An `AtomFunction<float, float>` that clamps the value using a min and a max value and returns it.

### Variables

#### `Min`

The minimum value.

---

#### `Max`

The maximum value.

---
