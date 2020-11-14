using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : PassiveMovement {

    public Run() : base(MovementType.RUN) {
        speed = 10.0f;
    }
}