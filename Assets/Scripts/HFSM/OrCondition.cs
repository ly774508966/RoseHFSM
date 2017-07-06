﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoseHFSM
{
    public class OrCondition : Condition
    {
        [SerializeField]
        public Condition a, b;  
        public override bool Check() {
            return a.Check() || b.Check();
        }
    }
}