using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    [Serializable]
    public struct FSMState
    {
        public string Id { get => _id.Value; }
        public FiniteStateMachine SubMachine { get => _subMachine; }
        public float Timer { get; set; }
        public float Duration { get => _duration.Value; }

        [SerializeField]
        private StringReference _id;

        [SerializeField]
        private FloatReference _duration;

        [SerializeField]
        private FiniteStateMachine _subMachine;
    }
}