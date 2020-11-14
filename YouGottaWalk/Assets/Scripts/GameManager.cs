using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public static MovementManager movementManager;
    public static Player player;

    private void Awake() {
        // Singleton handling.
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

        // Instantiate fields.
        movementManager = new MovementManager();

        // Find objects.
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }
}