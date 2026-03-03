using System;
using System.Collections.Generic;

class Kruskal
{
    class Edge
    {
        public int Src, Dest, Weight;
    }

    class Subset
    {
        public int Parent, Rank;
    }

    static int Find(Subset[] subsets, int i)
    {
        if (subsets[i].Parent != i)
            subsets[i].Parent = Find(subsets, subsets[i].Parent);
        return subsets[i].Parent;
    }

    static void Union(Subset[] subsets, int x, int y)
    {
        int xroot = Find(subsets, x);
        int yroot = Find(subsets, y);

        if (subsets[xroot].Rank < subsets[yroot].Rank)
            subsets[xroot].Parent = yroot;
        else if (subsets[xroot].Rank > subsets[yroot].Rank)
            subsets[yroot].Parent = xroot;
        else
        {
            subsets[yroot].Parent = xroot;
            subsets[xroot].Rank++;
        }
    }

    static void Main()
    {
        int V = 4;
        List<Edge> edges = new List<Edge>
        {
            new Edge{Src=0,Dest=1,Weight=10},
            new Edge{Src=0,Dest=2,Weight=6},
            new Edge{Src=0,Dest=3,Weight=5},
            new Edge{Src=1,Dest=3,Weight=15},
            new Edge{Src=2,Dest=3,Weight=4}
        };

        edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

        Subset[] subsets = new Subset[V];
        for (int v = 0; v < V; v++)
            subsets[v] = new Subset { Parent = v, Rank = 0 };

        foreach (var edge in edges)
        {
            int x = Find(subsets, edge.Src);
            int y = Find(subsets, edge.Dest);

            if (x != y)
            {
                Console.WriteLine(edge.Src + " - " + edge.Dest);
                Union(subsets, x, y);
            }
        }
    }
}