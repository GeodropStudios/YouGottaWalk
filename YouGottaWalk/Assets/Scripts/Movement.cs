using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType {
    CRAWL,
    WALK,
    RUN,
    JUMP,
    DASH,
    DRIVE,
    FLAP,
    SWIM,
    SUB,
    FLY,
    SPACE
}

public abstract class Movement {
    public MovementType type { get; private set; }

    public float speed { get; protected set; }

    public Movement(MovementType type) {
        this.type = type;
    }

    public abstract void Move(PlayerInput input);
}