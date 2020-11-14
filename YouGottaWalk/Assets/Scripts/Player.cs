using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    public PlayerInput playerInput { get; private set; }

    private void Start() {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update() {
        GameManager.movementManager.currentMovement.Move(playerInput);
    }
}