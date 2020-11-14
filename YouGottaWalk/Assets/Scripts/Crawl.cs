using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawl : PassiveMovement {

    public Crawl() : base(MovementType.CRAWL) {
        speed = 1.0f;
    }
}