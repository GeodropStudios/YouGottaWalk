using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PassiveMovement : Movement {
    
    public float speed { get; protected set; }

    public PassiveMovement(MovementType type) : base(type) { }
}
