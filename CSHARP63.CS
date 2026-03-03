using System;
using System.Collections.Generic;

class BellmanFord
{
    class Edge { public int Src, Dest, Weight; }

    static void Main()
    {
        int V = 5;
        List<Edge> edges = new List<Edge>
        {
            new Edge{Src=0,Dest=1,Weight=-1},
            new Edge{Src=0,Dest=2,Weight=4},
            new Edge{Src=1,Dest=2,Weight=3},
            new Edge{Src=1,Dest=3,Weight=2},
            new Edge{Src=1,Dest=4,Weight=2},
            new Edge{Src=3,Dest=2,Weight=5},
            new Edge{Src=3,Dest=1,Weight=1},
            new Edge{Src=4,Dest=3,Weight=-3}
        };

        int[] dist = new int[V];
        for (int i = 0; i < V; i++) dist[i] = int.MaxValue;
        dist[0] = 0;

        for (int i = 1; i < V; i++)
            foreach (var e in edges)
                if (dist[e.Src] != int.MaxValue &&
                    dist[e.Src] + e.Weight < dist[e.Dest])
                    dist[e.Dest] = dist[e.Src] + e.Weight;

        foreach (var d in dist)
            Console.WriteLine(d);
    }
}