---
id: unityatoms.ui
title: UnityAtoms.UI
hide_title: true
sidebar_label: UnityAtoms.UI
---

# Namespace - `UnityAtoms.UI`

## `UIContainer`

A MonoBehaviour that you can add to a `CanvasGroup` and makes it transition based on a `StringVariable` value. **TODO**: Add support for differnt transitions. Maybe integrate with DOTween?

### Variables

#### `_currentUIState`

Variable that we listens to.

---

#### `_visibleForStates`

A list of states that this `UIContainer` will be visible for.

### Methods

#### `OnEventRaised(System.String)`

Handler for when the state is changed.

##### Parameters

-   `stateName` - undefined

---
