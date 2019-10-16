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

## `AtomAction<T1>`

#### Type Parameters

-   `T1` - The type for this Action.

Generic abstract base class for Actions. Inherits from `BaseAtom`.

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

Generic abstract base class for Actions. Inherits from `BaseAtom`.

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

Generic abstract base class for Actions. Inherits from `BaseAtom`.

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

Generic abstract base class for Actions. Inherits from `BaseAtom`.

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

Generic abstract base class for Actions. Inherits from `BaseAtom`.

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

## `BoolAction`

Action of type `bool`. Inherits from `AtomAction<bool>`.

---

## `BoolBoolAction`

Action x 2 of type `bool`. Inherits from `AtomAction<bool, bool>`.

---

## `Collider2DAction`

Action of type `Collider2D`. Inherits from `AtomAction<Collider2D>`.

---

## `Collider2DCollider2DAction`

Action x 2 of type `Collider2D`. Inherits from `AtomAction<Collider2D, Collider2D>`.

---

## `ColliderAction`

Action of type `Collider`. Inherits from `AtomAction<Collider>`.

---

## `ColliderColliderAction`

Action x 2 of type `Collider`. Inherits from `AtomAction<Collider, Collider>`.

---

## `ColorAction`

Action of type `Color`. Inherits from `AtomAction<Color>`.

---

## `ColorColorAction`

Action x 2 of type `Color`. Inherits from `AtomAction<Color, Color>`.

---

## `FloatAction`

Action of type `float`. Inherits from `AtomAction<float>`.

---

## `FloatFloatAction`

Action x 2 of type `float`. Inherits from `AtomAction<float, float>`.

---

## `GameObjectAction`

Action of type `GameObject`. Inherits from `AtomAction<GameObject>`.

---

## `GameObjectGameObjectAction`

Action x 2 of type `GameObject`. Inherits from `AtomAction<GameObject, GameObject>`.

---

## `IntAction`

Action of type `int`. Inherits from `AtomAction<int>`.

---

## `IntIntAction`

Action x 2 of type `int`. Inherits from `AtomAction<int, int>`.

---

## `StringAction`

Action of type `string`. Inherits from `AtomAction<string>`.

---

## `StringStringAction`

Action x 2 of type `string`. Inherits from `AtomAction<string, string>`.

---

## `Vector2Action`

Action of type `Vector2`. Inherits from `AtomAction<Vector2>`.

---

## `Vector2Vector2Action`

Action x 2 of type `Vector2`. Inherits from `AtomAction<Vector2, Vector2>`.

---

## `Vector3Action`

Action of type `Vector3`. Inherits from `AtomAction<Vector3>`.

---

## `Vector3Vector3Action`

Action x 2 of type `Vector3`. Inherits from `AtomAction<Vector3, Vector3>`.

---

## `VoidAction`

Action of type `Void`. Inherits from `AtomAction<Void>`.

### Methods

#### `Do(UnityAtoms.Void)`

Do the Action.

##### Parameters

-   `_` - Dummy Void parameter.

---

#### `Do`

Do the Action.

---

## `SetBoolVariableValue`

Set variable value Action of type `bool`. Inherits from `SetVariableValue<bool, BoolVariable, BoolConstant, BoolReference, BoolEvent, BoolBoolEvent>`.

---

## `SetCollider2DVariableValue`

Set variable value Action of type `Collider2D`. Inherits from `SetVariableValue<Collider2D, Collider2DVariable, Collider2DConstant, Collider2DReference, Collider2DEvent, Collider2DCollider2DEvent>`.

---

## `SetColliderVariableValue`

Set variable value Action of type `Collider`. Inherits from `SetVariableValue<Collider, ColliderVariable, ColliderConstant, ColliderReference, ColliderEvent, ColliderColliderEvent>`.

---

## `SetColorVariableValue`

Set variable value Action of type `Color`. Inherits from `SetVariableValue<Color, ColorVariable, ColorConstant, ColorReference, ColorEvent, ColorColorEvent>`.

---

## `SetFloatVariableValue`

Set variable value Action of type `float`. Inherits from `SetVariableValue<float, FloatVariable, FloatConstant, FloatReference, FloatEvent, FloatFloatEvent>`.

---

## `SetGameObjectVariableValue`

Set variable value Action of type `GameObject`. Inherits from `SetVariableValue<GameObject, GameObjectVariable, GameObjectConstant, GameObjectReference, GameObjectEvent, GameObjectGameObjectEvent>`.

---

## `SetIntVariableValue`

Set variable value Action of type `int`. Inherits from `SetVariableValue<int, IntVariable, IntConstant, IntReference, IntEvent, IntIntEvent>`.

---

## `SetStringVariableValue`

Set variable value Action of type `string`. Inherits from `SetVariableValue<string, StringVariable, StringConstant, StringReference, StringEvent, StringStringEvent>`.

---

## `SetVariableValue<T,V,C,R,E1,E2>`

#### Type Parameters

-   `T` - The type of the Variable to set.
-   `V` - A Variable class of type `type` to set.
-   `C` - A Constant class of type `type` to set.
-   `R` - A Reference of type `type`.
-   `E1` - An Event of type `type`.
-   `E2` - An Event x 2 of type `type`.

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

## `SetVector2VariableValue`

Set variable value Action of type `Vector2`. Inherits from `SetVariableValue<Vector2, Vector2Variable, Vector2Constant, Vector2Reference, Vector2Event, Vector2Vector2Event>`.

---

## `SetVector3VariableValue`

Set variable value Action of type `Vector3`. Inherits from `SetVariableValue<Vector3, Vector3Variable, Vector3Constant, Vector3Reference, Vector3Event, Vector3Vector3Event>`.

---

## `EditorIcon`

Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.

---

## `BaseAtom`

None generic base class for all Atoms.

### Variables

#### `_developerDescription`

A description of the Atom made for documentation purposes.

---

## `BoolConstant`

Constant of type `bool`. Inherits from `AtomBaseVariable<bool>`.

---

## `Collider2DConstant`

Constant of type `Collider2D`. Inherits from `AtomBaseVariable<Collider2D>`.

---

## `ColliderConstant`

Constant of type `Collider`. Inherits from `AtomBaseVariable<Collider>`.

---

## `ColorConstant`

Constant of type `Color`. Inherits from `AtomBaseVariable<Color>`.

---

## `FloatConstant`

Constant of type `float`. Inherits from `AtomBaseVariable<float>`.

---

## `GameObjectConstant`

Constant of type `GameObject`. Inherits from `AtomBaseVariable<GameObject>`.

---

## `IntConstant`

Constant of type `int`. Inherits from `AtomBaseVariable<int>`.

---

## `StringConstant`

Constant of type `string`. Inherits from `AtomBaseVariable<string>`.

---

## `Vector2Constant`

Constant of type `Vector2`. Inherits from `AtomBaseVariable<Vector2>`.

---

## `Vector3Constant`

Constant of type `Vector3`. Inherits from `AtomBaseVariable<Vector3>`.

---

## `AtomEvent`

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

## `AtomEvent<T>`

#### Type Parameters

-   `T` - The type for this Event.

Generic base class for Events. Inherits from `AtomEvent`.

### Methods

#### `Raise(item)`

Raise the Event.

##### Parameters

-   `item` - The value associated with the Event.

---

#### `Register(del)`

Register handler to be called when the Event triggers.

##### Parameters

-   `del` - The handler.

---

#### `Unregister(del)`

Unregister handler that was registered using the `Register` method.

##### Parameters

-   `del` - The handler.

---

#### `RegisterListener(listener)`

Register a Listener that in turn trigger all its associated handlers when the Event triggers.

##### Parameters

-   `listener` - The Listenr to register.

---

#### `UnregisterListener(listener)`

Unregister a listener that was registered using the `RegisterListener` method.

##### Parameters

-   `listener` - The Listenr to unregister.

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

Generic base class for Events. Inherits from `AtomEvent`.

### Methods

#### `Raise(item1,item2)`

Raise the Event.

##### Parameters

-   `item1` - The first value associated with the Event.
-   `item2` - The second value associated with the Event.

---

#### `Register(del)`

Register handler to be called when the Event triggers.

##### Parameters

-   `del` - The handler.

---

#### `Unregister(del)`

Unregister handler that was registered using the `Register` method.

##### Parameters

-   `del` - The handler.

---

#### `RegisterListener(listener)`

Register a Listener that in turn trigger all its associated handlers when the Event triggers.

##### Parameters

-   `listener` - The Listenr to register.

---

#### `UnregisterListener(listener)`

Unregister a listener that was registered using the `RegisterListener` method.

##### Parameters

-   `listener` - The Listenr to unregister.

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

## `BoolBoolEvent`

Event x 2 of type `bool`. Inherits from `AtomEvent<bool, bool>`.

---

## `BoolEvent`

Event of type `bool`. Inherits from `AtomEvent<bool>`.

---

## `Collider2DCollider2DEvent`

Event x 2 of type `Collider2D`. Inherits from `AtomEvent<Collider2D, Collider2D>`.

---

## `Collider2DEvent`

Event of type `Collider2D`. Inherits from `AtomEvent<Collider2D>`.

---

## `ColliderColliderEvent`

Event x 2 of type `Collider`. Inherits from `AtomEvent<Collider, Collider>`.

---

## `ColliderEvent`

Event of type `Collider`. Inherits from `AtomEvent<Collider>`.

---

## `ColorColorEvent`

Event x 2 of type `Color`. Inherits from `AtomEvent<Color, Color>`.

---

## `ColorEvent`

Event of type `Color`. Inherits from `AtomEvent<Color>`.

---

## `FloatEvent`

Event of type `float`. Inherits from `AtomEvent<float>`.

---

## `FloatFloatEvent`

Event x 2 of type `float`. Inherits from `AtomEvent<float, float>`.

---

## `GameObjectEvent`

Event of type `GameObject`. Inherits from `AtomEvent<GameObject>`.

---

## `GameObjectGameObjectEvent`

Event x 2 of type `GameObject`. Inherits from `AtomEvent<GameObject, GameObject>`.

---

## `IntEvent`

Event of type `int`. Inherits from `AtomEvent<int>`.

---

## `IntIntEvent`

Event x 2 of type `int`. Inherits from `AtomEvent<int, int>`.

---

## `StringEvent`

Event of type `string`. Inherits from `AtomEvent<string>`.

---

## `StringStringEvent`

Event x 2 of type `string`. Inherits from `AtomEvent<string, string>`.

---

## `Vector2Event`

Event of type `Vector2`. Inherits from `AtomEvent<Vector2>`.

---

## `Vector2Vector2Event`

Event x 2 of type `Vector2`. Inherits from `AtomEvent<Vector2, Vector2>`.

---

## `Vector3Event`

Event of type `Vector3`. Inherits from `AtomEvent<Vector3>`.

---

## `Vector3Vector3Event`

Event x 2 of type `Vector3`. Inherits from `AtomEvent<Vector3, Vector3>`.

---

## `VoidEvent`

Event of type `Void`. Inherits from `AtomEvent<Void>`.

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

## `AtomListener<T,A,E,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `A` - Acion of type `AtomAction<T>`.
-   `E` - Event of type `AtomEvent<T>`.
-   `UER` - Unity Event of type `UnityEvent<T>`.

Generic base class for Listeners. Inherits from `BaseAtomListener` and `IAtomListener<T>`.

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

The Event we are listening for as a proeprty.

### Methods

#### `OnEventRaised(item)`

Handler for when the Event gets raised.

##### Parameters

-   `item` - The Event type.

---

## `AtomListener<T1,T2,A,E,UER>`

#### Type Parameters

-   `T1` - The first type that we are listening for.
-   `T2` - The second type that we are listening for.
-   `A` - Acion of type `AtomAction<T1, T2>`.
-   `E` - Event of type `AtomEvent<T1, T2>`.
-   `UER` - Unity Event of type `UnityEvent<T1, T2>`.

Generic base class for Listeners. Inherits from `BaseAtomListener` and `IAtomListener<T1, T2>`

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

The Event we are listening for as a proeprty.

### Methods

#### `OnEventRaised(first,second)`

Handler for when the Event gets raised.

##### Parameters

-   `first` - The first Event type.
-   `second` - The second Event type.

---

## `BaseAtomListener`

None generic base class for all Listeners.

### Variables

#### `_developerDescription`

A description of the Listener made for documentation purposes.

---

## `BoolBoolListener`

Listener x 2 of type `bool`. Inherits from `AtomListener<bool, bool, BoolBoolAction, BoolBoolEvent, BoolBoolUnityEvent>`.

---

## `BoolListener`

Listener of type `bool`. Inherits from `AtomListener<bool, BoolAction, BoolEvent, BoolUnityEvent>`.

---

## `Collider2DCollider2DListener`

Listener x 2 of type `Collider2D`. Inherits from `AtomListener<Collider2D, Collider2D, Collider2DCollider2DAction, Collider2DCollider2DEvent, Collider2DCollider2DUnityEvent>`.

---

## `Collider2DListener`

Listener of type `Collider2D`. Inherits from `AtomListener<Collider2D, Collider2DAction, Collider2DEvent, Collider2DUnityEvent>`.

---

## `ColliderColliderListener`

Listener x 2 of type `Collider`. Inherits from `AtomListener<Collider, Collider, ColliderColliderAction, ColliderColliderEvent, ColliderColliderUnityEvent>`.

---

## `ColliderListener`

Listener of type `Collider`. Inherits from `AtomListener<Collider, ColliderAction, ColliderEvent, ColliderUnityEvent>`.

---

## `ColorColorListener`

Listener x 2 of type `Color`. Inherits from `AtomListener<Color, Color, ColorColorAction, ColorColorEvent, ColorColorUnityEvent>`.

---

## `ColorListener`

Listener of type `Color`. Inherits from `AtomListener<Color, ColorAction, ColorEvent, ColorUnityEvent>`.

---

## `FloatFloatListener`

Listener x 2 of type `float`. Inherits from `AtomListener<float, float, FloatFloatAction, FloatFloatEvent, FloatFloatUnityEvent>`.

---

## `FloatListener`

Listener of type `float`. Inherits from `AtomListener<float, FloatAction, FloatEvent, FloatUnityEvent>`.

---

## `GameObjectGameObjectListener`

Listener x 2 of type `GameObject`. Inherits from `AtomListener<GameObject, GameObject, GameObjectGameObjectAction, GameObjectGameObjectEvent, GameObjectGameObjectUnityEvent>`.

---

## `GameObjectListener`

Listener of type `GameObject`. Inherits from `AtomListener<GameObject, GameObjectAction, GameObjectEvent, GameObjectUnityEvent>`.

---

## `IntIntListener`

Listener x 2 of type `int`. Inherits from `AtomListener<int, int, IntIntAction, IntIntEvent, IntIntUnityEvent>`.

---

## `IntListener`

Listener of type `int`. Inherits from `AtomListener<int, IntAction, IntEvent, IntUnityEvent>`.

---

## `StringListener`

Listener of type `string`. Inherits from `AtomListener<string, StringAction, StringEvent, StringUnityEvent>`.

---

## `StringStringListener`

Listener x 2 of type `string`. Inherits from `AtomListener<string, string, StringStringAction, StringStringEvent, StringStringUnityEvent>`.

---

## `Vector2Listener`

Listener of type `Vector2`. Inherits from `AtomListener<Vector2, Vector2Action, Vector2Event, Vector2UnityEvent>`.

---

## `Vector2Vector2Listener`

Listener x 2 of type `Vector2`. Inherits from `AtomListener<Vector2, Vector2, Vector2Vector2Action, Vector2Vector2Event, Vector2Vector2UnityEvent>`.

---

## `Vector3Listener`

Listener of type `Vector3`. Inherits from `AtomListener<Vector3, Vector3Action, Vector3Event, Vector3UnityEvent>`.

---

## `Vector3Vector3Listener`

Listener x 2 of type `Vector3`. Inherits from `AtomListener<Vector3, Vector3, Vector3Vector3Action, Vector3Vector3Event, Vector3Vector3UnityEvent>`.

---

## `VoidListener`

Listener of type `Void`. Inherits from `AtomListener<Void, VoidAction, VoidEvent, VoidUnityEvent>`.

---

## `AtomList<T,E>`

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

Add an item to tje list.

##### Parameters

-   `item` - The item to add.

---

#### `Remove(item)`

Remove and item from the list.

##### Parameters

-   `item` - The item to remove.

##### Returns

The removed item.

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

## `BaseAtomList`

None generic base class of Lists.Inherits from `BaseAtom`.

### Variables

#### `Cleared`

Event for when the list is cleared.

### Methods

#### `Clear`

Clear the list.

---

## `BoolList`

List of type `bool`. Inherits from `AtomList<bool, BoolEvent>`.

---

## `Collider2DList`

List of type `Collider2D`. Inherits from `AtomList<Collider2D, Collider2DEvent>`.

---

## `ColliderList`

List of type `Collider`. Inherits from `AtomList<Collider, ColliderEvent>`.

---

## `ColorList`

List of type `Color`. Inherits from `AtomList<Color, ColorEvent>`.

---

## `FloatList`

List of type `float`. Inherits from `AtomList<float, FloatEvent>`.

---

## `GameObjectList`

List of type `GameObject`. Inherits from `AtomList<GameObject, GameObjectEvent>`.

---

## `IntList`

List of type `int`. Inherits from `AtomList<int, IntEvent>`.

---

## `StringList`

List of type `string`. Inherits from `AtomList<string, StringEvent>`.

---

## `Vector2List`

List of type `Vector2`. Inherits from `AtomList<Vector2, Vector2Event>`.

---

## `Vector3List`

List of type `Vector3`. Inherits from `AtomList<Vector3, Vector3Event>`.

---

## `AtomReference`

None generic base class for `AtomReference<T, V>`.

### Variables

#### `_usage`

Should we use the provided value (via inspector), the Constant value or the Variable value?

---

## `AtomReference.Usage`

Enum for how to use the Reference.

---

## `BoolReference`

Reference of type `bool`. Inherits from `AtomReference<bool, BoolVariable, BoolConstant>`.

---

## `Collider2DReference`

Reference of type `Collider2D`. Inherits from `AtomReference<Collider2D, Collider2DVariable, Collider2DConstant>`.

---

## `ColliderReference`

Reference of type `Collider`. Inherits from `AtomReference<Collider, ColliderVariable, ColliderConstant>`.

---

## `ColorReference`

Reference of type `Color`. Inherits from `AtomReference<Color, ColorVariable, ColorConstant>`.

---

## `FloatReference`

Reference of type `float`. Inherits from `AtomReference<float, FloatVariable, FloatConstant>`.

---

## `GameObjectReference`

Reference of type `GameObject`. Inherits from `AtomReference<GameObject, GameObjectVariable, GameObjectConstant>`.

---

## `IntReference`

Reference of type `int`. Inherits from `AtomReference<int, IntVariable, IntConstant>`.

---

## `StringReference`

Reference of type `string`. Inherits from `AtomReference<string, StringVariable, StringConstant>`.

---

## `Vector2Reference`

Reference of type `Vector2`. Inherits from `AtomReference<Vector2, Vector2Variable, Vector2Constant>`.

---

## `Vector3Reference`

Reference of type `Vector3`. Inherits from `AtomReference<Vector3, Vector3Variable, Vector3Constant>`.

---

## `Void`

Dummy module class used for representing nothing in for example empty Events, eg: `AtomEvent<Void>`

---

## `BoolBoolUnityEvent`

None generic Unity Event x 2 of type `bool`. Inherits from `UnityEvent<bool, bool>`.

---

## `BoolUnityEvent`

None generic Unity Event of type `bool`. Inherits from `UnityEvent<bool>`.

---

## `Collider2DCollider2DUnityEvent`

None generic Unity Event x 2 of type `Collider2D`. Inherits from `UnityEvent<Collider2D, Collider2D>`.

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

## `ColorColorUnityEvent`

None generic Unity Event x 2 of type `Color`. Inherits from `UnityEvent<Color, Color>`.

---

## `ColorUnityEvent`

None generic Unity Event of type `Color`. Inherits from `UnityEvent<Color>`.

---

## `FloatFloatUnityEvent`

None generic Unity Event x 2 of type `float`. Inherits from `UnityEvent<float, float>`.

---

## `FloatUnityEvent`

None generic Unity Event of type `float`. Inherits from `UnityEvent<float>`.

---

## `GameObjectGameObjectUnityEvent`

None generic Unity Event x 2 of type `GameObject`. Inherits from `UnityEvent<GameObject, GameObject>`.

---

## `GameObjectUnityEvent`

None generic Unity Event of type `GameObject`. Inherits from `UnityEvent<GameObject>`.

---

## `IntIntUnityEvent`

None generic Unity Event x 2 of type `int`. Inherits from `UnityEvent<int, int>`.

---

## `IntUnityEvent`

None generic Unity Event of type `int`. Inherits from `UnityEvent<int>`.

---

## `StringStringUnityEvent`

None generic Unity Event x 2 of type `string`. Inherits from `UnityEvent<string, string>`.

---

## `StringUnityEvent`

None generic Unity Event of type `string`. Inherits from `UnityEvent<string>`.

---

## `Vector2UnityEvent`

None generic Unity Event of type `Vector2`. Inherits from `UnityEvent<Vector2>`.

---

## `Vector2Vector2UnityEvent`

None generic Unity Event x 2 of type `Vector2`. Inherits from `UnityEvent<Vector2, Vector2>`.

---

## `Vector3UnityEvent`

None generic Unity Event of type `Vector3`. Inherits from `UnityEvent<Vector3>`.

---

## `Vector3Vector3UnityEvent`

None generic Unity Event x 2 of type `Vector3`. Inherits from `UnityEvent<Vector3, Vector3>`.

---

## `VoidUnityEvent`

None generic Unity Event of type `Void`. Inherits from `UnityEvent<Void>`.

---

## `DynamicAtoms`

Static helper class for when creating Atoms a runtime (yes it is indeed possible 🤯).

### Methods

#### `CreateVariable<T,V,E1,E2>(initialValue,changed,changedWithHistory)`

Create a Variable at runtime.

#### Type Parameters

-   `T` - The Variable value type.
-   `V` - The Variable type AtomVariable<T, E1, E2>`.
-   `E1` - The type of the `changed` Event of type `AtomEvent<T>`.
-   `E2` - The type of the `changedWithHistory` Event of type `AtomEvent<T, T>`.

##### Parameters

-   `initialValue` - Inital value of the Variable created.
-   `changed` - Changed Event of type `E1`.
-   `changedWithHistory` - Changed with history Event of type `E2`.

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

#### `Equals(System.Object)`

Determines equality between Variables.

##### Parameters

-   `obj` - The other Variable to compare as an `object`.

##### Returns

`true` if they are equal, otherwise `false`.

---

#### `GetHashCode`

Get an unique hash code for this Variable based on the Variable's value.

##### Returns

An unique hash.

---

#### `op_Equality(left,right)`

Equal operator.

##### Parameters

-   `left` - The first Variable to compare.
-   `right` - The second Variable to compare.

##### Returns

`true` if eqaul, otherwise `false`.

---

#### `op_Inequality(left,right)`

None equality operator.

##### Parameters

-   `left` - The first Variable to compare.
-   `right` - The second Variable to compare.

##### Returns

`true` if not eqaul, otherwise `false`.

---

#### `Reset(System.Boolean)`

Not implemented.abstract Throws Exception

---

## `AtomVariable<T,E1,E2>`

#### Type Parameters

-   `T` - The Variable value type.
-   `E1` - Event of type `AtomEvent<T>`.
-   `E2` - Event of type `AtomEvent<T, T>`.

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

#### `OldValue`

The value the Variable had before its value got changed last time.

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

## `BoolVariable`

Variable of type `bool`. Inherits from `EquatableAtomVariable<bool, BoolEvent, BoolBoolEvent>`.

---

## `Collider2DVariable`

Variable of type `Collider2D`. Inherits from `AtomVariable<Collider2D, Collider2DEvent, Collider2DCollider2DEvent>`.

---

## `ColliderVariable`

Variable of type `Collider`. Inherits from `AtomVariable<Collider, ColliderEvent, ColliderColliderEvent>`.

---

## `ColorVariable`

Variable of type `Color`. Inherits from `EquatableAtomVariable<Color, ColorEvent, ColorColorEvent>`.

---

## `FloatVariable`

Variable of type `float`. Inherits from `EquatableAtomVariable<float, FloatEvent, FloatFloatEvent>`.

---

## `GameObjectVariable`

Variable of type `GameObject`. Inherits from `AtomVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>`.

---

## `IntVariable`

Variable of type `int`. Inherits from `EquatableAtomVariable<int, IntEvent, IntIntEvent>`.

---

## `StringVariable`

Variable of type `string`. Inherits from `EquatableAtomVariable<string, StringEvent, StringStringEvent>`.

---

## `Vector2Variable`

Variable of type `Vector2`. Inherits from `EquatableAtomVariable<Vector2, Vector2Event, Vector2Vector2Event>`.

---

## `Vector3Variable`

Variable of type `Vector3`. Inherits from `EquatableAtomVariable<Vector3, Vector3Event, Vector3Vector3Event>`.

---

## `VoidGameObjectUnityEvent`

None generic Unity Event x 2 of type `Void` and `GameObject`. Inherits from `UnityEvent<Void, GameObject>`.

---
