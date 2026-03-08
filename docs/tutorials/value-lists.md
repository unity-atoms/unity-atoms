# Value Lists

ValueLists are the go-to collection type in Unity Atoms. You can think of it as a `AtomVariable<List<T>>`.

A common use case is storing a list of Enemies for easy access.

## Creating an Enemy Prefab

1. Adding a Cube to the Scene and creating a prefab out of. I named it "AngryCube".

<video controls width="600">
  <source src="../assets/valuelist/valuelist_01_setup.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>

2. Now add a `Sync GameObjectToList` component to the prefab. This will automatically add instances of the prefab onto the list on `Start` (and removes them `OnDestroy`)
3. Press the `[Create]` Button on the `Sync GameObjectToList` component to create a new ValueList asset, we name it "ListOfEnemyGameObjects".

<video controls width="600">
  <source src="../assets/valuelist/valuelist_02_create_and_sync.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>

4. In play mode, we can now observe the ValueList asset and see how gameobjects are added to it on start and removed when leaving the play mode.

<video controls width="600">
  <source src="../assets/valuelist/valuelist_03_inspect.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>

