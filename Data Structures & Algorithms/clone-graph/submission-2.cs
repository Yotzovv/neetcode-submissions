/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node)
    {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        return BFS(node);
    }

    public Node BFS(Node node)
    {
        if (node == null) return null;
        
        var oldToNew = new Dictionary<Node, Node>();
        var queue = new Queue<Node>();
        oldToNew[node] = new Node(node.val);
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var neighbor in current.neighbors)
            {
                if (!oldToNew.ContainsKey(neighbor))
                {
                    oldToNew[neighbor] = new Node(neighbor.val);
                    queue.Enqueue(neighbor);
                }
                oldToNew[current].neighbors.Add(oldToNew[neighbor]);
            }
        }
        return oldToNew[node];
    }

    public Node Dfs(Node? node, Dictionary<Node, Node> oldToNew)
    {
        if (node == null) return null;
        if (oldToNew.ContainsKey(node)) return oldToNew[node];
        
        Node copy = new Node(node.val);
        oldToNew[node] = copy;

        foreach (var neighbor in node.neighbors)
            copy.neighbors.Add(Dfs(neighbor, oldToNew));

        return copy;
    }
}
