using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput {

    public bool button0 { get; private set; }
    public float horizontal { get; private set; } = 0.0f;
    public float vertical { get; private set; } = 0.0f;

    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        button0 = Input.GetKey(KeyCode.Space);
    }
}