﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RoseHFSM
{
    /// <summary>
    /// A state that contains another HFSM
    /// </summary>
    public class ParentState : State
    {

        [SerializeField]
        private HFSM stateHFSM;
        public HFSM StateHFSM
        {
            get { return stateHFSM;  }
            set { stateHFSM = value;  }
        }

        protected override void RunState()
        {
            base.RunState();
            stateHFSM.Execute();
        }
    }
}