---
id: tags
title: Tags
hide_title: true
sidebar_label: Tags
---

:::caution

The following Content was (mostly) written by Chat-GPT and only proofread by Soraphis

:::

# Unity Atoms / Tags

A replacement to Unity´s tags based on Unity Atoms. See the [API](../api/unityatoms.tags) for more info.

The **Tags** subpackage of Unity Atoms is a powerful tool enhances Unity's existing tag functionality by allowing for dynamic and scriptable tag operations.

## Using the Tags Subpackage

### Adding/Removing Tags from a GameObject

To assign a tag to a GameObject, use the `AtomTags` component that comes with the AtomTags subpackage.  The easiest way is to add the Tags in the Inspector, but it's also possible to add/remove tags at runtime using `StringConstants`:

Here's an example:
```
StringConstant myTag;

...

Tag tagComponent = gameObject.AddComponent<AtomTags>();
tagComponent.AddTag(myTag);
tagComponent.RemoveTag(myTag.Value);
```
### Get Tags of an GameObjects

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

The Tag packages is fine tuned to reduce heap allocations as much as possible, some results are discussed here: https://github.com/unity-atoms/unity-atoms/pull/12#issuecomment-470656166

## Conclusion

The Tags subpackage is a robust and dynamic tool that enhances the built-in tag functionality of Unity. By using scriptable tags, your code can become more flexible and maintainable.
