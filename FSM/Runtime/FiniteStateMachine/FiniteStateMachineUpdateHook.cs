using System;
using UnityEngine;

namespace UnityAtoms.FSM
{
    public class FiniteStateMachineUpdateHook : MonoBehaviour
    {
        public static FiniteStateMachineUpdateHook GetInstance(bool createIfNotExist = false)
        {
            if (_instance == null && createIfNotExist)
            {
                GameObject go = new GameObject("FiniteStateMachineUpdateHook");
                _instance = go.AddComponent<FiniteStateMachineUpdateHook>();
            }

            return _instance;
        }

        public event Action<float> OnUpdate;

        private static FiniteStateMachineUpdateHook _instance;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            if (OnUpdate != null)
            {
                OnUpdate.Invoke(Time.deltaTime);
            }
        }
    }
}