using System;
using System.Collections.Generic;

class MaxFlow
{
    static bool BFS(int[,] rGraph, int s, int t, int[] parent)
    {
        bool[] visited = new bool[6];
        Queue<int> q = new Queue<int>();
        q.Enqueue(s);
        visited[s] = true;
        parent[s] = -1;

        while (q.Count != 0)
        {
            int u = q.Dequeue();
            for (int v = 0; v < 6; v++)
                if (!visited[v] && rGraph[u, v] > 0)
                {
                    parent[v] = u;
                    visited[v] = true;
                    q.Enqueue(v);
                }
        }
        return visited[t];
    }

    static void Main()
    {
        int[,] graph = {
            {0,16,13,0,0,0},
            {0,0,10,12,0,0},
            {0,4,0,0,14,0},
            {0,0,9,0,0,20},
            {0,0,0,7,0,4},
            {0,0,0,0,0,0}
        };

        int[,] rGraph = (int[,])graph.Clone();
        int[] parent = new int[6];
        int maxFlow = 0;

        while (BFS(rGraph, 0, 5, parent))
        {
            int pathFlow = int.MaxValue;
            for (int v = 5; v != 0; v = parent[v])
            {
                int u = parent[v];
                pathFlow = Math.Min(pathFlow, rGraph[u, v]);
            }

            for (int v = 5; v != 0; v = parent[v])
            {
                int u = parent[v];
                rGraph[u, v] -= pathFlow;
                rGraph[v, u] += pathFlow;
            }

            maxFlow += pathFlow;
        }

        Console.WriteLine(maxFlow);
    }
}