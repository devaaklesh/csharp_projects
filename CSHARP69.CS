using System;
using System.Collections.Generic;

class TopologicalSort
{
    static void DFS(int v, bool[] visited, Stack<int> stack, List<int>[] graph)
    {
        visited[v] = true;

        foreach (int i in graph[v])
            if (!visited[i])
                DFS(i, visited, stack, graph);

        stack.Push(v);
    }

    static void Main()
    {
        int V = 6;
        List<int>[] graph = new List<int>[V];
        for (int i = 0; i < V; i++) graph[i] = new List<int>();

        graph[5].Add(2);
        graph[5].Add(0);
        graph[4].Add(0);
        graph[4].Add(1);
        graph[2].Add(3);
        graph[3].Add(1);

        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
            if (!visited[i])
                DFS(i, visited, stack, graph);

        while (stack.Count > 0)
            Console.Write(stack.Pop() + " ");
    }
}