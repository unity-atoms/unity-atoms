using UnityEngine;
using UnityAtoms.Tags;

public class TagEventSub : MonoBehaviour
{
    private AtomTags atomTags;

    private void Start()
    {
        atomTags = GetComponent<AtomTags>();

        if(atomTags != null){
            atomTags.TagAdded += OnTagAdded;
            atomTags.TagRemoved += OnTagRemoved;
        }
    }

    private void OnDisable()
    {
        //Unsubscribe the events
        atomTags.OnTagAdded -= OnTagAdded;
        atomTags.OnTagRemoved -= OnTagRemoved;
    }
}

private void OnTagAdded(string tag)
{
    // Identifying the tag that has been added.
    Debug.Log("Tag added: " + tag);
}

private void OnTagRemoved(string tag)
{
    // Identifying the tag that has been removed.
    Debug.Log("Tag removed: " + tag);
}