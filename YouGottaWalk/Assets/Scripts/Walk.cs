﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : PassiveMovement {

    public Walk() : base(MovementType.WALK) {
        speed = 5.0f;
    }
}