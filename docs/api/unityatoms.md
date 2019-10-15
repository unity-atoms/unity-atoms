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

## `VoidAction`

Action of type Void. Inherits from `AtomAction<Void>`.

### Methods

#### `Do(UnityAtoms.Void)`

Do the Action.

##### Parameters

-   `_` - Dummy Void parameter.

---

#### `Do`

Do the Action.

---

## `SetVariableValue<T,V,R,E1,E2>`

#### Type Parameters

-   `T` - The type of the Variable to set.
-   `V` - A Variable class of type `type` to set.
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

## `EditorIcon`

Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.

---

## `BaseAtom`

None generic base class for all atoms.

### Variables

#### `_developerDescription`

A description of the Atom made for developers to document their Atoms.

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

Generic base class for Listeners. Inherits from `MonoBehaviour` and `IAtomListener<T>`.

### Variables

#### `_event`

The Event that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses.

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

Generic base class for Listeners. Inherits from `MonoBehaviour` and `IAtomListener<T1, T2>`

### Variables

#### `_event`

The Event that we are listening to.

---

#### `_unityEventResponse`

The Unity Event responses.

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

## `Runtime`

Internal constant and static readonly members for runtime usage.

---

## `Runtime.Constants`

Runtime constants

### Variables

#### `LOG_PREFIX`

Prefix that should be pre-pended to all Debug.Logs made from UnityAtoms to help immediately inform a user that those logs are made from this library.

---
