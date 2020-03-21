using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Script to decrease a Unit's health.
    /// </summary>
    public class DecreaseHealth : MonoBehaviour
    {
        public List<StringConstant> TagsAffected { get => _tags; }

        [SerializeField]
        private IntReference _decreaseBy;

        [SerializeField]
        private List<StringConstant> _tags;

        [SerializeField]
        private VoidBaseEventReference _didCollide;

        void Start()
        {
            Assert.IsNotNull(_decreaseBy);
            Assert.IsNotNull(_tags);
        }

        public void Do(Collider2D collider)
        {
            if (collider == null) return;

            if (collider.gameObject.HasAnyTag(_tags))
            {
                collider.GetComponent<UnitHealth>().Health -= _decreaseBy;
            }

            if (_didCollide != null && _didCollide.Event != null)
            {
                _didCollide.Event.Raise();
            }
        }
    }
}