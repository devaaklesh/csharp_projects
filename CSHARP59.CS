using System;

class Prims
{
    static int MinKey(int[] key, bool[] mstSet, int V)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
            if (!mstSet[v] && key[v] < min)
            {
                min = key[v];
                minIndex = v;
            }
        return minIndex;
    }

    static void Main()
    {
        int V = 5;
        int[,] graph = {
            {0,2,0,6,0},
            {2,0,3,8,5},
            {0,3,0,0,7},
            {6,8,0,0,9},
            {0,5,7,9,0}
        };

        int[] parent = new int[V];
        int[] key = new int[V];
        bool[] mstSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            key[i] = int.MaxValue;
            mstSet[i] = false;
        }

        key[0] = 0;
        parent[0] = -1;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinKey(key, mstSet, V);
            mstSet[u] = true;

            for (int v = 0; v < V; v++)
                if (graph[u, v] != 0 && !mstSet[v] && graph[u, v] < key[v])
                {
                    parent[v] = u;
                    key[v] = graph[u, v];
                }
        }

        for (int i = 1; i < V; i++)
            Console.WriteLine(parent[i] + " - " + i);
    }
}