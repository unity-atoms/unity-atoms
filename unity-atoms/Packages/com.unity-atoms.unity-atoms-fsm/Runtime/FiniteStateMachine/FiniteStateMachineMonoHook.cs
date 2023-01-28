using System;
using UnityEngine;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Needed By FiniteStateMachine in order to gain access to some of the Unity life cycle methods.
    /// </summary>
    public class FiniteStateMachineMonoHook : MonoBehaviour
    {
        public static FiniteStateMachineMonoHook GetInstance(bool createIfNotExist = false)
        {
            if (_instance == null && createIfNotExist)
            {
                GameObject go = new GameObject("FiniteStateMachineUpdateHook");
                _instance = go.AddComponent<FiniteStateMachineMonoHook>();
            }

            return _instance;
        }

        public event Action OnStart;
        public event Action<float> OnUpdate;
        public event Action<float> OnFixedUpdate;

        private static FiniteStateMachineMonoHook _instance;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
        }

        private void Start()
        {
            if (OnStart != null)
            {
                OnStart.Invoke();
            }
        }

        private void Update()
        {
            if (OnUpdate != null)
            {
                OnUpdate.Invoke(Time.deltaTime);
            }
        }

        private void FixedUpdate()
        {
            if (OnFixedUpdate != null)
            {
                OnFixedUpdate.Invoke(Time.deltaTime);
            }
        }
    }
}