using System;

class Hamiltonian
{
    static int V = 5;
    static int[,] graph = {
        {0,1,0,1,0},
        {1,0,1,1,1},
        {0,1,0,0,1},
        {1,1,0,0,1},
        {0,1,1,1,0}
    };

    static int[] path = new int[V];

    static bool IsSafe(int v, int pos)
    {
        if (graph[path[pos - 1], v] == 0)
            return false;

        for (int i = 0; i < pos; i++)
            if (path[i] == v)
                return false;

        return true;
    }

    static bool Solve(int pos)
    {
        if (pos == V)
            return graph[path[pos - 1], path[0]] == 1;

        for (int v = 1; v < V; v++)
        {
            if (IsSafe(v, pos))
            {
                path[pos] = v;
                if (Solve(pos + 1))
                    return true;
                path[pos] = -1;
            }
        }
        return false;
    }

    static void Main()
    {
        for (int i = 0; i < V; i++) path[i] = -1;
        path[0] = 0;
        Solve(1);

        foreach (var p in path)
            Console.Write(p + " ");
    }
}