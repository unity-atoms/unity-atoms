---
id: unityatoms.editor
title: UnityAtoms.Editor
hide_title: true
sidebar_label: UnityAtoms.Editor
---

# Namespace - `UnityAtoms.Editor`

## `AtomReferenceDrawer`

A custom property drawer for References. Makes it possible to choose between a Variable and a constant value (not a Atom Contant, but a regular value).

---

## `AtomType`

Internal module class that holds that regarding an Atom type.

---

## `AtomTypes`

Internal static class holding predefined static `AtomType`s.

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
