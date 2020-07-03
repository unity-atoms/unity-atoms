---
id: unityatoms.editor
title: UnityAtoms.Editor
hide_title: true
sidebar_label: UnityAtoms.Editor
---

# Namespace - `UnityAtoms.Editor`

## `EditorIconPostProcessor`

Postprocessor that processes all scripts using the EditorIcon attribute and assigns the matching icon guid (matching the icon query name) to the script's meta. It's a very simple solution (and very hacky), but works really great.

### Methods

#### `OnPostprocessAllAssets(System.String[],System.String[],System.String[],System.String[])`

Called when new assets are imported, deleted or moved.

##### Parameters

-   `importedAssets` - Imported assets.
-   `deletedAssets` - Deleted assets.
-   `movedAssets` - Moved assets.
-   `movedFromAssetPaths` - Moved from asset paths.

---

## `RegenereateAllAtoms`

Internal utility class to regenerate all Atoms. Reachable via top menu bar and `Tools/Unity Atoms/Regenerate All Atoms`.

### Methods

#### `Regenereate`

Create the editor window.

---

## `Templating`

Internal class used for templating when generating new Atoms using the `Generator`.

### Methods

#### `ResolveConditionals(System.String,System.Collections.Generic.List{System.String})`

Resolve conditionals from the provided tempalte.

##### Parameters

-   `template` - Template to resolve the conditionals from.
-   `trueConditions` - A list of conditionals that are `true`.

##### Returns

A new template string resolved and based on the provided `template`.

---

#### `ResolveVariables(System.Collections.Generic.Dictionary{System.String,System.String},System.String)`

Resolve variables in the provided string.

##### Parameters

-   `templateVariables` - Dictionay mapping template variables and their resolutions.
-   `toResolve` - The string to resolve.

##### Returns

A new template string resolved and based on the provided `toResolve` string.

---

## `GeneratorEditor`

Editor class for the `Generator`. Use it via the top window bar at _Tools / Unity Atoms / Generator_. Only availble in `UNITY_2019_1_OR_NEWER`.

### Methods

#### `Init`

Create the editor window.

---

#### `AddAtomTypeToGenerate(UnityAtoms.Editor.AtomType)`

Add provided `AtomType` to the list of Atom types to be generated.

##### Parameters

-   `atomType` - The `AtomType` to be added.

---

#### `RemoveAtomTypeToGenerate(UnityAtoms.Editor.AtomType)`

Remove provided `AtomType` from the list of Atom types to be generated.

##### Parameters

-   `atomType` - The `AtomType` to be removed.

---

#### `SetWarningText(UnityAtoms.Editor.AtomType,System.Collections.Generic.List{UnityAtoms.Editor.AtomType})`

Set and display warning text in the editor.

##### Parameters

-   `atomType` - `AtomType` to generate the warning for.
-   `disabledDeps` - List of disabled deps.

---

#### `OnEnable`

Called when editor is enabled.

---

#### `CreateDivider`

Helper method to create a divider.

##### Returns

The divider (`VisualElement`) created.

---

#### `CreateAtomTypeToGenerateToggleRow(UnityAtoms.Editor.AtomType)`

Helper to create toogle row for a specific `AtomType`.

##### Parameters

-   `atomType` - The provided `AtomType`.

##### Returns

A new toggle row (`VisualElement`).

---

## `AtomReceipe`

Internal module class that holds that regarding an Atom type.

---

## `AtomType`

Internal module class that holds that regarding an Atom type.

---

## `Generator`

Generator that generates new Atom types based on the input data. Used by the `GeneratorEditor`. Only availble in `UNITY_2019_1_OR_NEWER`.

### Methods

#### `Generate(UnityAtoms.Editor.AtomReceipe,System.String,System.String[],System.Collections.Generic.List{System.String},System.Collections.Generic.Dictionary{System.String,System.String})`

Generate new Atoms based on the input data.

##### Parameters

-   `valueType` - The type of Atom to generate.abstract Eg. double, byte, MyStruct, MyClass.
-   `baseWritePath` - Base write path (relative to the Asset folder) where the Atoms are going to be written to.
-   `isEquatable` - Is the `type` provided implementing `IEquatable`?
-   `atomTypesToGenerate` - A list of `AtomType`s to be generated.
-   `typeNamespace` - If the `type` provided is defined under a namespace, provide that namespace here.
-   `subUnityAtomsNamespace` - By default the Atoms that gets generated will be under the namespace `UnityAtoms`. If you for example like it to be under `UnityAtoms.MyNamespace` you would then enter `MyNamespace` in this field.

##### Examples

```cs
namespace MyNamespace
{
    public struct MyStruct
    {
        public string Text;
        public int Number;
    }
}
var generator = new Generator();
generator.Generate("MyStruct", "", false, new List<AtomType>() { AtomTypes.ACTION }, "MyNamespace", ""); // Generates an Atom Action of type MyStruct
```

---

#### `RemoveDuplicateNamespaces(System.String)`

Removes duplicate namespaces, given content from a template.

##### Parameters

-   `template` - The content template to remove namespace from.

##### Returns

A copy of `content`, but without duplicate namespaces.

---

## `AtomTypes`

Internal static class holding predefined static `AtomType`s.

### Variables

#### `ALL_ATOM_TYPES`

Containes all common atom types that are usually generated for a type.

---

#### `DEPENDENCY_GRAPH`

Graph explaining all the dependencies between Atoms.

---

## `AtomEventReferenceDrawer`

A custom property drawer for Event References. Makes it possible to choose between an Event, Event Instancer, Variable or a Variable Instancer.

---

## `AtomDrawer<T>`

#### Type Parameters

-   `T` - The type of Atom the property drawer should apply to.

The base Unity Atoms property drawer. Makes it possible to create and add a new Atom via Unity's inspector. Only availble in `UNITY_2018_3_OR_NEWER`.

---

## `AtomReferenceDrawer`

A custom property drawer for References. Makes it possible to choose between a Value, Variable, Constant or a Variable Instancer.

---

## `AtomBaseReferenceDrawer`

A custom property drawer for References (Events and regular). Makes it possible to reference a resources (Variable or Event) through multiple options.

---

## `ReadOnlyDrawer`

Make property read only by using the abbtribute `[ReadOnly]`. Solution taken from: https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html

---

## `AtomListAttributeDrawer`

A custom property drawer for properties using the `AtomList` attribute.

---

## `AtomVariableEditor`2`

Custom editor for Variables. Provides a better user workflow and indicates when which variables can be edited

---

## `AtomEventEditor<T,E>`

#### Type Parameters

-   `T` - The type of this event..
-   `E` - Event of type T.

Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.

---
