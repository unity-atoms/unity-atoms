**Q: Why do my Atoms lose their Value on Scene Load?**

This is one of the differences between Editor and Builds:

ScriptableObjects behave differently in build than editor. 
(In Editor, the changes persist on the file, In the build, there is no "file" that has the changes, so each time it is loaded it loads the values that were present when the build was done)

Loading a scene (non-async non-additive) unloads your current scene, and it free's currently loaded assets (textures, meshes, scriptable objects (in a build)). then the next scene is loaded, assume it uses the same scriptable objects: those will be new scriptable objects. since the old one where unloaded.

If you only register onto events, there is no hard reference anymore to the asset. (that's usually why one is using events, so that the event-source does not need to know every handler, but it could give unity the impression that the asset is unused and can be unloaded)

One possibly simple way to solve that:
- create an object, with a component that stores a list of AtomEvents or AtomVariables or something like this, add all assets that need to survive scene loads there.
- the component should call DontDestroyOnLoad on Start, so it keeps a references to all these assets.

more on this topic:

> If a single mode scene is loaded, Unity calls Resources.UnloadUnusedAssets automatically.
> -- https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html


https://docs.unity3d.com/ScriptReference/Resources.UnloadUnusedAssets.html