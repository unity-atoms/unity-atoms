---
id: faq
title: FAQ
hide_title: true
sidebar_label: FAQ
---

# Frequently Asked Questions

**Q: Where can I read a summary of what Unity Atoms has to offer?**

The [overview](overview.md) section of this page has information about the basic idea of Unity Atoms.

---

**Q: How did Unity Atoms get started?**

Some history for the project can be read from this blog post on [Medium](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) by the author.

For those interested in the details, Unity Atoms is derived from and a continuation of [Ryan Hipple's talk from Unite 2017](https://youtu.be/raQ3iHhE_Kk). 

Quote:
> "Game Architecture with Scriptable Objects focuses on making modular, data-driven, editable game systems while avoiding (and trash talking) crutch patterns like singletons.
>
> Using ScriptableObject based classes, you can easily edit and store references to data from prefabs in a scene. However, ScriptableObjects are not constrained to just static data. You can change data from one prefab and read it from another. This allows for the exchange of state between prefabs without the need for a rigid connection between them.
>
> A similar pattern can be used to construct an event system. Scene objects can add themselves to a list on a ScriptableObject based asset to indicate that they are listening for a certain game event. Later, a different scene object can "raise" the event, looping through the list and notifying all listening objects. Again, this pattern removes rigid connections between different systems in the game."

[Source](http://www.roboryantron.com/2017/10/unite-2017-game-architecture-with.html)

[Ryan Hipple's sample project](https://github.com/roboryantron/Unite2017)

---

**Q: How does Unity Atoms compare to [ScriptableObject-Architecture](https://github.com/DanielEverland/ScriptableObject-Architecture) by Daniel Everland?**

A: The two are very similar, so the differences range from small to trivial:

Features Unity Atoms has but ScriptableObject-Architecture does not:
- More feature-complete
- Variable and event instancers
- UniRx compatibility
- More options in code generator
- Larger (Discord) community

Features Scriptableobject-Architecture has but Unity Atoms does not:
- Visual event debugging
- More predefined variable types in create menu
- Different game event types in create menu
- Collapse button to hide the stack trace during debugging

---

**Q: What will the future of Unity Atoms be?**

A: Currently Unity Atoms is really pushing the use of generics to its limits in order to please Unity's serializer. This makes it unnecessarily hard to introduce new features to the library. If the API (generic signature) is breaking between major releases it makes it difficult for users to upgrade.

Unity 2020 will support serialization of generic fields. Unity Atoms could shave off a good chunk of the source code and make the library more sustainable by embracing this new feature.

---

**Q: Where can I ask questions or support the project?**

A: To get started, check out the tutorials on this page.

If you still happen to have questions, don't hesitate to join the [Discord server](https://discord.gg/W4yd7E7) and you will find many helpful individuals to assist you in figuring out Unity Atoms. There are also channels for suggestions and showcasing your work, which is all welcome!

Unity Atoms is an open source project and anyone may contribute to help improve Unity Atoms. Check out the [GitHub repository](https://github.com/unity-atoms/unity-atoms), [contributing guideline](https://github.com/unity-atoms/unity-atoms/blob/master/CONTRIBUTING.md), and become part of the project!
