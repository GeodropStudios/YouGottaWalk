using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType {
    CRAWL,
    WALK,
    RUN,
    JUMP,
    DRIVE,
    FLAP,
    SWIM,
    SUB,
    FLY,
    SPACE
}

public abstract class Movement {
    public MovementType type { get; private set; }

    public Movement(MovementType type) {
        this.type = type;
    }

    public abstract void Move(float horizontalAxis, float verticalAxis, int button);
}
