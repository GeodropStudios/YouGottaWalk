using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PassiveMovement : Movement {

    public PassiveMovement(MovementType type) : base(type) { }

    public override void Move(PlayerInput input) {
        GameManager.player.transform.position += Vector3.right * speed * Time.deltaTime;
    }
}