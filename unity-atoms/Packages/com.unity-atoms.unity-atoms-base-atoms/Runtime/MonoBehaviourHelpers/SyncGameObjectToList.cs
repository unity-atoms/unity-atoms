using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds a GameObject to a GameObject Value List on OnEnable and removes it on OnDestroy.
    /// </summary>
    [AddComponentMenu("Unity Atoms/MonoBehaviour Helpers/Sync GameObject To List")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncGameObjectToList : MonoBehaviour
    {
        [SerializeField]
        private GameObjectValueList _list = default;

        void OnEnable()
        {
            Assert.IsNotNull(_list);
            _list.Add(gameObject);
        }

        void OnDestroy()
        {
            _list.Remove(gameObject);
        }
    }
}