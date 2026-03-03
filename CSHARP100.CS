using System;
using System.Collections.Generic;

class Program
{
    static int time=0;

    static void DFS(int u,bool[] visited,int[] disc,int[] low,int[] parent,List<int>[] adj)
    {
        visited[u]=true;
        disc[u]=low[u]=++time;

        foreach(var v in adj[u])
        {
            if(!visited[v])
            {
                parent[v]=u;
                DFS(v,visited,disc,low,parent,adj);
                low[u]=Math.Min(low[u],low[v]);

                if(low[v]>disc[u])
                    Console.WriteLine(u+"-"+v);
            }
            else if(v!=parent[u])
                low[u]=Math.Min(low[u],disc[v]);
        }
    }

    static void Main()
    {
        int V=5;
        List<int>[] adj=new List<int>[V];
        for(int i=0;i<V;i++)
            adj[i]=new List<int>();

        adj[1].Add(0);
        adj[0].Add(2);
        adj[2].Add(1);
        adj[0].Add(3);
        adj[3].Add(4);

        bool[] visited=new bool[V];
        int[] disc=new int[V];
        int[] low=new int[V];
        int[] parent=new int[V];

        for(int i=0;i<V;i++)
            parent[i]=-1;

        DFS(0,visited,disc,low,parent,adj);
    }
}