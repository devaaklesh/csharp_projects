using System;
using System.Collections.Generic;

class DFS
{
    static void Traverse(List<int>[] graph, int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int adj in graph[v])
            if (!visited[adj])
                Traverse(graph, adj, visited);
    }

    static void Main()
    {
        List<int>[] graph = new List<int>[4];
        for (int i = 0; i < 4; i++) graph[i] = new List<int>();

        graph[0].Add(1);
        graph[0].Add(2);
        graph[1].Add(2);
        graph[2].Add(0);
        graph[2].Add(3);
        graph[3].Add(3);

        bool[] visited = new bool[4];
        Traverse(graph, 2, visited);
    }
}