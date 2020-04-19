---
id: unityatoms.tags
title: UnityAtoms.Tags
hide_title: true
sidebar_label: UnityAtoms.Tags
---

# Namespace - `UnityAtoms.Tags`

## `ReadOnlyList<T>`

#### Type Parameters

-   `T` - The type of the list items.

This is an `IList` without everything that could mutate the it.

### Properties

#### `Count`

Get the number of elements contained in the `ReadOnlyList<T>`.

##### Examples

```cs
var readOnlyList = new ReadOnlyList<int>(new List<int>() { 1, 2, 3 });
Debug.Log(readOnlyList.Count); // Outputs: 3
```

---

#### `IsReadOnly`

Determines if the `ReadOnlyList<T>` is read only or not.

---

#### `Item(System.Int32)`

Get the element at the specified index.

### Methods

#### `#ctor(list)`

Creates a new class of the `ReadOnlyList<T>` class.

##### Parameters

-   `list` - The `IList<T>` to initialize the `ReadOnlyList<T>` with.

---

#### `GetEnumerator`

Implements `GetEnumerator()` of `IEnumerable<T>`

##### Returns

The list's `IEnumerator<T>`.

---

#### `Contains(item)`

Determines whether an element is in the `ReadOnlyList<T>`.

##### Parameters

-   `item` - The item to check if it exists in the `ReadOnlyList<T>`.

##### Returns

`true` if item is found in the `ReadOnlyList<T>`; otherwise, `false`.

---

#### `IndexOf(item)`

Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

##### Parameters

-   `item` - The one-dimensional array to search.

##### Returns

The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.

---

#### `CopyTo(array,arrayIndex)`

Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 32-bit integer.

##### Parameters

-   `array` - The one-dimensional array that is the destination of the elements copied from the current array.
-   `arrayIndex` - A 32-bit integer that represents the index in array at which copying begins.

---

## `GameObjectExtensions`

`GameObject` extensions related to tags in Unity Atoms.

### Methods

#### `GetTags(UnityEngine.GameObject)`

Retrieves all tags for a given `GameObject`. A faster alternative to `gameObject.GetComponen<UATags>().Tags`.

##### Parameters

-   `go` - This `GameObject`

##### Returns

A `ReadOnlyList<T>` of tags stored as `StringContant`s. Returns `null` if the `GameObject` does not have any tags or if the `GameObject` is disabled.

---

#### `HasTag(UnityEngine.GameObject,System.String)`

Check if the tag provided is associated with this `GameObject`.

##### Parameters

-   `go` - This `GameObject`
-   `tag` - The tag to search for.

##### Returns

`true` if the tag exists, otherwise `false`.

---

#### `HasAnyTag(UnityEngine.GameObject,System.Collections.Generic.List{System.String})`

Check if any of the tags provided are associated with this `GameObject`.

##### Parameters

-   `go` - This `GameObject`
-   `tags` - The tags to search for.

##### Returns

`true` if any of the tags exist, otherwise `false`.

---

## `AtomTags`

A MonoBehaviour that adds tags the Unity Atoms way to a GameObject.

### Properties

#### `Tags`

Get the tags associated with this GameObject as `StringConstants` in a `ReadOnlyList<T>`.

### Methods

#### `HasTag(System.String)`

Check if the tag provided is associated with this `GameObject`.

##### Parameters

-   `tag` - undefined

##### Returns

`true` if the tag exists, otherwise `false`.

---

#### `RemoveTag(System.String)`

Remove a tag from this `GameObject`.

##### Parameters

-   `tag` - The tag to remove as a `string`

---

#### `FindByTag(System.String)`

Find first `GameObject` that has the tag provided.

##### Parameters

-   `tag` - The tag that the `GameObject` that you search for will have.

##### Returns

The first `GameObject` with the provided tag found. If no `GameObject`is found, it returns `null`.

---

#### `FindAllByTag(System.String)`

Find all `GameObject`s that have the tag provided.

##### Parameters

-   `tag` - The tag that the `GameObject`s that you search for will have.

##### Returns

An array of `GameObject`s with the provided tag. If not found it returns `null`.

---

#### `FindAllByTagNoAlloc(System.String,System.Collections.Generic.List{UnityEngine.GameObject})`

Find all `GameObject`s that have the tag provided. Mutates the output `List<GameObject>` and adds the `GameObject`s found to it.

##### Parameters

-   `tag` - The tag that the `GameObject`s that you search for will have.
-   `output` - A `List<GameObject>` that this method will clear and add the `GameObject`s found to.

---

#### `GetTagsForGameObject(UnityEngine.GameObject)`

A faster alternative to `gameObject.GetComponen<UATags>()`.

##### Returns

Returns the `UATags` component. Returns `null` if the `GameObject` does not have a `UATags` component or if the `GameObject` is disabled.

---

#### `GetTags(UnityEngine.GameObject)`

Retrieves all tags for a given `GameObject`. A faster alternative to `gameObject.GetComponen<UATags>().Tags`.

##### Parameters

-   `go` - The `GameObject` to check for tags.

##### Returns

A `ReadOnlyList<T>` of tags stored as `StringContant`s. Returns `null` if the `GameObject` does not have any tags or if the `GameObject` is disabled.

---
