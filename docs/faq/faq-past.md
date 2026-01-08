**Q: How did Unity Atoms get started?**

Some history for the project can be read from this blog post on [Medium](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) by the author.

For those interested in the details, Unity Atoms is derived from and is a continuation of [Ryan Hipple's talk from Unite 2017](https://youtu.be/raQ3iHhE_Kk). 

Quote:
> "Game Architecture with Scriptable Objects focuses on making modular, data-driven, editable game systems while avoiding (and trash talking) crutch patterns like singletons.
>
> Using ScriptableObject based classes, you can easily edit and store references to data from prefabs in a scene. However, ScriptableObjects are not constrained to just static data. You can change data from one prefab and read it from another. This allows for the exchange of state between prefabs without the need for a rigid connection between them.
>
> A similar pattern can be used to construct an event system. Scene objects can add themselves to a list on a ScriptableObject based asset to indicate that they are listening for a certain game event. Later, a different scene object can "raise" the event, looping through the list and notifying all listening objects. Again, this pattern removes rigid connections between different systems in the game."

[Source](http://www.roboryantron.com/2017/10/unite-2017-game-architecture-with.html)

[Ryan Hipple's sample project](https://github.com/roboryantron/Unite2017)