---
id: unityatoms
title: UnityAtoms
hide_title: true
sidebar_label: UnityAtoms
---

# Namespace - `UnityAtoms`

## `Void`

Dummy module class used for representing nothing in for example empty Events, eg: `AtomEvent<Void>`

---

## `EquatableAtomReference<T,P,C,V,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the variable.
-   `P` - IPair of type `T`.
-   `C` - Constant of type `T`.
-   `V` - Variable of type `T`.
-   `E1` - Event of type `T`.
-   `E2` - Event of type `IPair<T>`.
-   `F` - Function of type `T => T`.
-   `VI` - Variable Instancer of type `T`.

Atom Reference that where the value is implementing `IEquatable`.

---

## `AtomReferenceUsage`

Different Reference usages.

---

## `AtomBaseReference`

None generic base class for `AtomReference<T, C, V, E1, E2, F, VI>`.

### Variables

#### `_usage`

Describes how we use the Reference and where the value comes from.

---

## `AtomReference<T,P,C,V,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the variable.
-   `P` - IPair of type `T`.
-   `C` - Constant of type `T`.
-   `V` - Variable of type `T`.
-   `E1` - Event of type `T`.
-   `E2` - Event of type `IPair<T>`.
-   `F` - Function of type `T => T`.
-   `VI` - Variable Instancer of type `T`.

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

## `AtomEventReferenceUsage`

Different types of Event Reference usages.

---

## `AtomBaseEventReference`

Base class for Event References.

### Variables

#### `_usage`

Describes how we use the Event Reference.

---

## `AtomBaseEventReference<T,E,EI>`

#### Type Parameters

-   `T` - The type of the event.
-   `E` - Event of type `T`.
-   `EI` - Event Instancer of type `T`.

An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Event Instancer, Variable or a Variable Instancer.

### Variables

#### `_event`

Event used if `Usage` is set to `Event`.

---

#### `_eventInstancer`

EventInstancer used if `Usage` is set to `EventInstancer`.

### Properties

#### `Event`

Get the event for the Event Reference.

### Methods

#### `GetEvent<E>`

Get event by type.

#### Type Parameters

-   `E` - undefined

##### Returns

The event.

---

#### `SetEvent<E>(e)`

Set event by type.

#### Type Parameters

-   `E` - undefined

##### Parameters

-   `e` - The new event value.

---

## `AtomEventReference<T,V,E,VI,EI>`

#### Type Parameters

-   `T` - The type of the event.
-   `V` - Variable of type `T`.
-   `E` - Event of type `T`.
-   `VI` - Variable Instancer of type `T`.
-   `EI` - Event Instancer of type `T`.

An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Event Instancer, Variable or a Variable Instancer.

### Variables

#### `_variable`

Variable used if `Usage` is set to `Variable`.

---

#### `_variableInstancer`

Variable Instancer used if `Usage` is set to `VariableInstancer`.

### Properties

#### `Event`

Get or set the Event used by the Event Reference.

---

## `AtomListWrapper<T>`

#### Type Parameters

-   `T` - Type used in list.

Needed in order to create a property drawer for a List / Array. See this for more info: https://answers.unity.com/questions/605875/custompropertydrawer-for-array-types-in-43.html

---

## `AtomVariableInstancer<V,P,T,E1,E2,F>`

#### Type Parameters

-   `V` - Variable of type T.
-   `P` - IPair of type `T`.
-   `T` - The value type.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T

A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable. This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to react accordingly when a prefab with an associated atom is added or deleted to the scene.

### Methods

#### `ImplSpecificSetup`

Override to add implementation specific setup on `OnEnable`.

---

#### `GetEvent<E>`

Get event by type.

#### Type Parameters

-   `E` - undefined

##### Returns

The event.

---

#### `SetEvent<E>(e)`

Set event by type.

#### Type Parameters

-   `E` - undefined

##### Parameters

-   `e` - The new event value.

---

## `AtomBaseVariableInstancer<V,P,T,E1,E2,F>`

#### Type Parameters

-   `V` - Variable of type T.
-   `P` - IPair of type `T`.
-   `T` - The value type.
-   `E1` - Event of type T.
-   `E2` - Event x 2 of type T.
-   `F` - Function of type T => T

A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable. This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to react accordingly when a prefab with an assoicated atom is added or deleted to the scene.

### Variables

#### `_base`

The variable that the in memory copy will be based on when created at runtime.

### Properties

#### `Variable`

Getter for retrieving the in memory runtime variable.

---

#### `Value`

Getter for retrieving the value of the in memory runtime variable.

### Methods

#### `ImplSpecificSetup`

Override to add implementation specific setup on `OnEnable`.

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

## `Runtime.ExecutionOrder`

Constants for defining DefaultExecutionOrder.

---

## `EditorIcon`

Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.

---

## `ReadOnlyAttribute`

Use to make a field read only in the Unity inspector. Solution taken from here: https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html

---

## `AtomEventInstancer<T,E>`

#### Type Parameters

-   `T` - The value type.
-   `E` - Event of type T.

An Event Instancer is a MonoBehaviour that takes an Event as a base and creates an in memory copy of it on OnEnable. This is handy when you want to use Events for prefabs that are instantiated at runtime.

### Variables

#### `_base`

The Event that the in memory copy will be based on when created at runtime.

### Properties

#### `Event`

Getter for retrieving the in memory runtime Event.

### Methods

#### `GetEvent<E>`

Get event by type.

#### Type Parameters

-   `E` - undefined

##### Returns

The event.

---

#### `SetEvent<E>(e)`

Set event by type.

#### Type Parameters

-   `E` - undefined

##### Parameters

-   `e` - The new event value.

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

## `AtomVariable<T,P,E1,E2,F>`

#### Type Parameters

-   `T` - The Variable value type.
-   `P` - IPair of type `T`.
-   `E1` - Event of type `AtomEvent<T>`.
-   `E2` - Event of type `AtomEvent<T, T>`.
-   `F` - Function of type `FunctionEvent<T, T>`.

Generic base class for Variables. Inherits from `AtomBaseVariable<T>`.

### Variables

#### `Changed`

Changed Event triggered when the Variable value gets changed.

---

#### `ChangedWithHistory`

Changed with history Event triggered when the Variable value gets changed.

---

#### `_initialValue`

The inital value of the Variable.

### Properties

#### `Value`

The Variable value as a property.

---

#### `InitialValue`

The initial value as a property.

---

#### `OldValue`

The value the Variable had before its value got changed last time.

---

#### `PreChangeTransformers`

When setting the value of a Variable the new value will be piped through all the pre change transformers, which allows you to create custom logic and restriction on for example what values can be set for this Variable.

### Methods

#### `Reset(System.Boolean)`

Reset the Variable to its `_initialValue`.

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

#### `GetEvent<E>`

Get event by type.

#### Type Parameters

-   `E` - undefined

##### Returns

The event.

---

#### `SetEvent<E>(e)`

Set event by type.

#### Type Parameters

-   `E` - undefined

##### Parameters

-   `e` - The new event value.

---

## `EquatableAtomVariable<T,P,E1,E2,F>`

#### Type Parameters

-   `T` - The Variable type.
-   `P` - Pair of type T.
-   `E1` - Event of type T.
-   `E2` - Pair event of type T.
-   `F` - Function of type T and T.

Atom Variable base class for types that are implementing `IEquatable<T>`.

---

## `AtomAction`

Base abstract class for Actions. Inherits from `BaseAtom`.

### Methods

#### `Do`

Perform the Action.

---

## `AtomAction<T1>`

#### Type Parameters

-   `T1` - The type for this Action.

Generic abstract base class for Actions. Inherits from `AtomAction`.

### Methods

#### `Do(t1)`

Perform the Action.

##### Parameters

-   `t1` - The first parameter.

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

## `AtomEvent<T>`

#### Type Parameters

-   `T` - The type for this Event.

Generic base class for Events. Inherits from `AtomEventBase`.

### Variables

#### `_replayBufferSize`

The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx.

---

#### `_inspectorRaiseValue`

Used when raising values from the inspector for debugging purposes.

### Properties

#### `ReplayBuffer`

Retrieve Replay Buffer as a List. This call will allocate memory so use sparsely.

### Methods

#### `Raise(item)`

Raise the Event.

##### Parameters

-   `item` - The value associated with the Event.

---

#### `RaiseEditor(item)`

Used in editor scipts since Raise is ambigious when using reflection to get method.

##### Parameters

-   `item` - undefined

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

#### `UnregisterAll`

Unregister all handlers that were registered using the `Register` method.

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

## `AtomEventReferenceListener<T,E,ER,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `E` - Event of type `T`.
-   `ER` - Event Reference of type `T`.
-   `UER` - UnityEvent of type `T`.

Generic base class for Listeners using Event Reference. Inherits from `AtomListener<T, E, UER>` and implements `IAtomListener<T>`.

### Variables

#### `_eventReference`

The Event Reference that we are listening to.

### Properties

#### `Event`

The Event we are listening for as a property.

---

## `AtomBaseListener`

None generic base class for all Listeners.

### Variables

#### `_developerDescription`

A description of the Listener made for documentation purposes.

---

## `AtomBaseListener<T,E,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `E` - Event of type `T`.
-   `UER` - UnityEvent of type `T`.

Generic base class for Listeners. Inherits from `AtomBaseListener` and implements `IAtomListener<T>`.

### Variables

#### `_unityEventResponse`

The Unity Event responses. NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).

---

#### `_actionResponses`

The Action responses;

### Properties

#### `Event`

The Event we are listening for as a property.

### Methods

#### `OnEventRaised(item)`

Handler for when the Event gets raised.

##### Parameters

-   `item` - The Event type.

---

#### `DebugLog(`0)`

Helper to register as listener callback

---

## `AtomEventListener<T,E,UER>`

#### Type Parameters

-   `T` - The type that we are listening for.
-   `E` - Event of type `T`.
-   `UER` - UnityEvent of type `T`.

Generic base class for Listeners using Event. Inherits from `AtomListener<T, E, UER>` and implements `IAtomListener<T>`.

### Variables

#### `_event`

The Event that we are listening to.

### Properties

#### `Event`

The Event we are listening for as a property.

---

## `VariableResetter`

Resets all the Variables in the list on OnEnable. Note that this will cause Events on the Variables to be triggered.

---

## `BaseAtom`

None generic base class for all Atoms.

### Variables

#### `_developerDescription`

A description of the Atom made for documentation purposes.

---

## `AtomValueList<T,E>`

#### Type Parameters

-   `T` - The list item type.
-   `E` - Event of type `AtomEvent<T>`.

Generic base class for Value Lists. Inherits from `BaseAtomList` and `IList<T>`.

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

## `BaseAtomValueList`

None generic base class of Lists. Inherits from `BaseAtom`.

### Variables

#### `Cleared`

Event for when the list is cleared.

### Methods

#### `Clear`

Clear the list.

---

## `IPair`1`

Interface defining a generic `IPair<T>`.

---

## `IIsValid`

Interface defining an `IsValid` method.

---

## `ISetEvent`

Interface for setting an event.

---

## `IGetEvent`

Interface for getting an event.

---

## `IAtomCollection`

Interface for Atom Collections.

---

## `IVariable`1`

Interface for retrieving a Variable.

---

## `IGetValue`1`

Interface for getting a value.

---

## `IAtomList`

Interface for Atom Lists.

---

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

#### `Capitalize(System.String)`

Capitalize the provided string.

##### Parameters

-   `str` - The string to capitalize.

##### Returns

A capitalized version of the string provided.

---

## `SetVariableValue<T,P,V,C,R,E1,E2,F,VI>`

#### Type Parameters

-   `T` - The type of the Variable to set.
-   `P` - A IPair of type T.
-   `V` - A Variable class of type `T` to set.
-   `C` - A Constant class of type `T`.
-   `R` - A Reference of type `T`.
-   `E1` - An Event of type `T`.
-   `E2` - An Event x 2 of type `T`.
-   `F` - A Function x 2 of type `T`.
-   `VI` - A Variable Instancer of type `T`.

Base class for all SetVariableValue Actions. Inherits from `AtomAction`.

### Variables

#### `_variable`

The Variable to set.

---

#### `_value`

The value to use.

### Methods

#### `Do`

Perform the action.

---
