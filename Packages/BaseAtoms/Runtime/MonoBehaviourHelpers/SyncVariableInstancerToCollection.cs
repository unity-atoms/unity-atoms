using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds a Variable from a Variable Instancer to a Collection or List on OnEnable and removes it on OnDestroy.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public class SyncVariableInstancerToCollection<T, V, VI> : MonoBehaviour
        where V : AtomBaseVariable<T>
        where VI : class, IVariable<V>
    {
        /// <summary>
        /// The Variable Instancer whose Variable will get synced to the List and / or Collection defined.
        /// </summary>
        [SerializeField]
        private VI _variableInstancer = default;

        /// <summary>
        /// If assigned the Variable from the Variable Instancer will be added to the Collection on Start using `_syncToCollectionKey` as key or if not specified it uses the gameObject's instance id as key. The value will also be removed from the collection OnDestroy.
        /// </summary>
        [SerializeField]
        private AtomCollectionReference _syncToCollection = default;

        /// <summary>
        /// If this string is not null or white space and if a Collection to sync to is defined, this is the key that will used when adding the Variable to the Collection. If not defined the key defaults to this GameObject's instance id.
        /// </summary>
        [SerializeField]
        private String _syncToCollectionKey = default;

        /// <summary>
        /// If assigned the Variable from the Variable Instancer will be added to the list on Start. The value will also be removed from the list OnDestroy.
        /// </summary>
        [SerializeField]
        private AtomListReference _syncToList = default;

        private void Start()
        {
            Assert.IsNotNull(_variableInstancer);

            if (_syncToCollection != null && _syncToCollection.GetValue() != null)
            {
                _syncToCollection.GetValue().Add(String.IsNullOrWhiteSpace(_syncToCollectionKey) ? GetInstanceID().ToString() : _syncToCollectionKey, _variableInstancer.Variable);
            }

            if (_syncToList != null && _syncToList.GetValue() != null)
            {
                _syncToList.GetValue().Add(_variableInstancer.Variable);
            }
        }

        private void OnDestroy()
        {
            if (_syncToCollection != null && _syncToCollection.GetValue() != null)
            {
                _syncToCollection.GetValue().Remove(GetInstanceID().ToString());
            }

            if (_syncToList != null && _syncToList.GetValue() != null)
            {
                _syncToList.GetValue().Remove(_variableInstancer.Variable);
            }
        }
    }
}