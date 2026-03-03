using System;
using System.Collections.Generic;

class Kosaraju
{
    static void DFS(int v, bool[] visited, Stack<int> stack, List<int>[] graph)
    {
        visited[v] = true;
        foreach (var n in graph[v])
            if (!visited[n])
                DFS(n, visited, stack, graph);
        stack.Push(v);
    }

    static void Main()
    {
        int V = 5;
        List<int>[] graph = new List<int>[V];
        for (int i = 0; i < V; i++) graph[i] = new List<int>();

        graph[1].Add(0);
        graph[0].Add(2);
        graph[2].Add(1);
        graph[0].Add(3);
        graph[3].Add(4);

        bool[] visited = new bool[V];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < V; i++)
            if (!visited[i])
                DFS(i, visited, stack, graph);

        while (stack.Count > 0)
            Console.WriteLine(stack.Pop());
    }
}