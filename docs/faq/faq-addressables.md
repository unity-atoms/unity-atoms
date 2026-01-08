**Q: Can I use UnityAtoms with Addressables?**

Yes, but there are pitfalls. A good understanding of memory management of unity assets is helpful.

Some best practices have been shared by the community:

- Make sure that Atoms are never duplicated by addressable groups.
    - Pack all Atoms into their own seperate packed asset group.
    - Note that your startup scene is never an Addressable scene, and you can have duplicates between atoms used there and in Addressables managed scenes.
        - So it can be helpful, to load into an empty "bootstrapper"/"splashscreen" scene first, if you need Atoms already in your main menu

more on this topic:

- https://github.com/unity-atoms/unity-atoms/issues/243
- https://discord.com/channels/640589221136171020/1447961883058634832
- https://discord.com/channels/640589221136171020/643165315546742785/1087917882555506718