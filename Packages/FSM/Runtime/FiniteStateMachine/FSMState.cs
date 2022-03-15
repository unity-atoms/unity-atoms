using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Class representing a state in the FSM.
    /// </summary>
    [Serializable]
    public class FSMState
    {
        public string Id { get => _id.Value; }
        public FiniteStateMachine SubMachine { get => _subMachine; }
        public float Timer { get; set; }
        public float Cooldown { get => _cooldown.Value; }

        [SerializeField]
        private AtomReference<string> _id = default(AtomReference<string>);

        [SerializeField]
        private AtomReference<float> _cooldown = new AtomReference<float>(0f);

        [SerializeField, HideCreate]
        private FiniteStateMachine _subMachine = default(FiniteStateMachine);
    }
}
