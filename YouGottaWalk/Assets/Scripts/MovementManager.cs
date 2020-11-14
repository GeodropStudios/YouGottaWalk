using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager {

    public Movement currentMovement {
        get {
            return movementGraph.GetElement(currentMovementNode);
        }
    }

    public List<Movement> nextMovements {
        get {
            return movementGraph.GetNeighborElements(currentMovementNode);
        }
    }

    private Graph<Movement> movementGraph;
    private int currentMovementNode = 0;

    public MovementManager() {
        // Construct movement graph.
        movementGraph = new Graph<Movement>();

        // Add nodes for movement.
        movementGraph.AddNode(new Crawl());
        movementGraph.AddNode(new Walk());
        movementGraph.AddNode(new Run());

        // Add edges for transitions between movements.
        movementGraph.AddEdge(0, 1);
        movementGraph.AddEdge(1, 2);
    }

    public bool AdvanceMovement(Movement next) {
        List<int> neighbors = movementGraph.GetNeighbors(currentMovementNode);
        bool found = false;

        foreach (int neighbor in neighbors) {
            foreach (Movement movement in nextMovements) {
                if (movement.type == next.type) {
                    currentMovementNode = neighbor;
                    found = true;
                    break;
                }
            }
            if (found) {
                break;
            }
        }

        return found;
    }
}