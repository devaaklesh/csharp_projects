using System;
using System.Collections.Generic;

class Program
{
    static void DFS(int v, bool[] visited, Stack<int> stack, List<int>[] adj)
    {
        visited[v] = true;
        foreach (var i in adj[v])
            if (!visited[i])
                DFS(i, visited, stack, adj);
        stack.Push(v);
    }

    static void Main()
    {
        int V = 6;
        List<int>[] adj = new List<int>[V];
        for (int i = 0; i < V; i++)
            adj[i] = new List<int>();

        adj[5].Add(2);
        adj[5].Add(0);
        adj[4].Add(0);
        adj[4].Add(1);
        adj[2].Add(3);
        adj[3].Add(1);

        bool[] visited = new bool[V];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < V; i++)
            if (!visited[i])
                DFS(i, visited, stack, adj);

        while (stack.Count > 0)
            Console.Write(stack.Pop() + " ");
    }
}