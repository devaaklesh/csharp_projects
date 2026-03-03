using System;
using System.Collections.Generic;

class Program
{
    class Edge
    {
        public int Src, Dest, Weight;
        public Edge(int s, int d, int w)
        {
            Src = s; Dest = d; Weight = w;
        }
    }

    static void BellmanFord(List<Edge> edges, int V, int src)
    {
        int[] dist = new int[V];
        for (int i = 0; i < V; i++)
            dist[i] = int.MaxValue;
        dist[src] = 0;

        for (int i = 1; i < V; i++)
            foreach (var e in edges)
                if (dist[e.Src] != int.MaxValue && dist[e.Src] + e.Weight < dist[e.Dest])
                    dist[e.Dest] = dist[e.Src] + e.Weight;

        for (int i = 0; i < V; i++)
            Console.WriteLine(dist[i]);
    }

    static void Main()
    {
        var edges = new List<Edge>
        {
            new Edge(0,1,4),
            new Edge(0,2,5),
            new Edge(1,2,-3),
            new Edge(2,3,4)
        };
        BellmanFord(edges,4,0);
    }
}