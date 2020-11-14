using System.Collections;
using System.Collections.Generic;

public class Graph<T> {

    private List<List<int>> neighborList;
    private List<T> nodes;

    public Graph() {
        neighborList = new List<List<int>>();
        nodes = new List<T>();
    }

    public List<int> GetNeighbors(int node) {
        return neighborList[node];
    }

    public List<T> GetNeighborElements(int node) {
        List<T> result = new List<T>();
        GetNeighbors(node).ForEach(neighbor => result.Add(GetElement(neighbor)));
        return result;
    }

    public T GetElement(int node) {
        return nodes[node];
    }

    public void AddNode(T element) {
        nodes.Add(element);
    }

    public void AddEdge(int from, int to) {
        if (neighborList[from] == null) {
            neighborList[from] = new List<int>();
        } else {
            neighborList[from].Add(to);
        }
    }
}