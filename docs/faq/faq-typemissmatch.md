
**Q: In the Inspector it says "type mismatch"?**

This will be fixed with UnityAtoms 4.6

It means that you're storing a reference to a scene object in an asset. this is not allowed and as soon as the playmode stops this is an invalid reference.