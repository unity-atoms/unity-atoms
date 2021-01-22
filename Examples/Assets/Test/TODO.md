# Unity Atoms v5

## Features

### Generic serialization ⭐️

Use Unity's new capability to serialize generics

### Improve debugability large projects

Visualize all atoms and MBs in a specific scene that are referencing those atoms.

### Selectors / Derrived Variable

Derrive state from several Atoms. Eg. combine AtomVariable<int> and AtomVariable<bool> to AtomVariable<Tuple<int, bool>>

See: https://recoiljs.org/docs/basic-tutorial/selectors

### Mutations / transactions ⭐️

Group changes of several atoms into one transaction (like a database transaction).

### Batch change events ⭐️

Wait triggering change events until a specific phase, eg. trigger on LateUpdate.

### Reactive lists

Like Atom List, but also possible to subscribe to when a list item is being modified.

### Group Atoms / SOs in the project hierarchy

Eg. add events as sub assets to a variable

### Templates

Starter C# templates for certain atoms, eg. AtomFunction / AtomAction

## Structural changes

### CI /CD

https://github.com/game-ci

### Github organization

### Break out website + Unity project to there own repos

Using git sub modules.
