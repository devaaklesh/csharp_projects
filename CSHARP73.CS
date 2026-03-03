using System;

class TSP
{
    static int V = 4;
    static int[,] graph = {
        {0,10,15,20},
        {10,0,35,25},
        {15,35,0,30},
        {20,25,30,0}
    };

    static int[,] dp = new int[1 << 4, 4];

    static int Solve(int mask, int pos)
    {
        if (mask == (1 << V) - 1)
            return graph[pos, 0];

        if (dp[mask, pos] != 0)
            return dp[mask, pos];

        int ans = int.MaxValue;

        for (int city = 0; city < V; city++)
            if ((mask & (1 << city)) == 0)
                ans = Math.Min(ans,
                    graph[pos, city] +
                    Solve(mask | (1 << city), city));

        return dp[mask, pos] = ans;
    }

    static void Main()
    {
        Console.WriteLine(Solve(1, 0));
    }
}