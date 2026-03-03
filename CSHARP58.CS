using System;

class FloydWarshall
{
    static void Main()
    {
        int V = 4;
        int INF = 99999;

        int[,] graph = {
            {0, 5, INF, 10},
            {INF, 0, 3, INF},
            {INF, INF, 0, 1},
            {INF, INF, INF, 0}
        };

        for (int k = 0; k < V; k++)
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    if (graph[i, k] + graph[k, j] < graph[i, j])
                        graph[i, j] = graph[i, k] + graph[k, j];

        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
                Console.Write(graph[i, j] + " ");
            Console.WriteLine();
        }
    }
}