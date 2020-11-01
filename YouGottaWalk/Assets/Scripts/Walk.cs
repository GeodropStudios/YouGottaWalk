using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : PassiveMovement {

    public Walk() : base(MovementType.WALK) {
        speed = 5.0f;
    }

    public override void Move(float horizontalAxis, float verticalAxis, int button) {
        throw new System.NotImplementedException();
    }
}
