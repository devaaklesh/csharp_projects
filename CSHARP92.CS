using System;

class Program
{
    static void Main()
    {
        int[] set={3,34,4,12,5,2};
        int sum=9,n=set.Length;
        bool[,] dp=new bool[n+1,sum+1];

        for(int i=0;i<=n;i++)
            dp[i,0]=true;

        for(int i=1;i<=n;i++)
            for(int s=1;s<=sum;s++)
                if(set[i-1]>s)
                    dp[i,s]=dp[i-1,s];
                else
                    dp[i,s]=dp[i-1,s]||dp[i-1,s-set[i-1]];

        Console.WriteLine(dp[n,sum]);
    }
}