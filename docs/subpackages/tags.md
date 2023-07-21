---
id: tags
title: Tags
hide_title: true
sidebar_label: Tags
---

# Unity Atoms / Tags

A replacement to Unity's tags based on Unity Atoms.

The **Tags** subpackage of Unity Atoms is a powerful tool that enhances Unity's existing tag functionality by allowing for dynamic and scriptable tag operations.

## Using the Tags subpackage

### Adding and removing tags from a GameObject

To assign a tag to a GameObject, use the `AtomTags` component that comes with the AtomTags subpackage.  The easiest way is to add the Tags in the Inspector, but it's also possible to add/remove tags at runtime using `StringConstants`:

Here's an example:
```
StringConstant myTag;

...

Tag tagComponent = gameObject.AddComponent<AtomTags>();
tagComponent.AddTag(myTag);
tagComponent.RemoveTag(myTag.Value);
```
### Get tags of an GameObjects

To see if a GameObject has a specific tag:
```
GameObject go;
...
go.HasTag("a");
```

or any tag within a list:

```
go.HasAnyTag(new List<string>() { "d", "f", "h", "j", "l" });
```

Or to get all the tags a gameobject has:

```
AtomTags.GetTagsForGameObject(go);
```

### Querying GameObjects by Tags

To find all GameObjects with a specific tag, use the `FindObjectsWithTag` method:

```
IEnumerable<GameObject> enemies = AtomTags.FindByTag("Enemy");
```

This will return all GameObjects with the tag "Enemy".

## Performance

The Tag packages is fine tuned to reduce heap allocations as much as possible. Some results are discussed [here](https://github.com/unity-atoms/unity-atoms/pull/12#issuecomment-470656166).

