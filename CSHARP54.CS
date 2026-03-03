using System;
using System.Collections.Generic;

class BFS
{
    static void Traverse(List<int>[] graph, int start)
    {
        bool[] visited = new bool[graph.Length];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            Console.Write(node + " ");

            foreach (int adj in graph[node])
            {
                if (!visited[adj])
                {
                    visited[adj] = true;
                    queue.Enqueue(adj);
                }
            }
        }
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

        Traverse(graph, 2);
    }
}