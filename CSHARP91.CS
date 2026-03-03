using System;

class Program
{
    static void Main()
    {
        int[] arr={1,2,3,4};
        int n=arr.Length;
        int[,] m=new int[n,n];

        for(int L=2;L<n;L++)
            for(int i=1;i<n-L+1;i++)
            {
                int j=i+L-1;
                m[i,j]=int.MaxValue;
                for(int k=i;k<j;k++)
                    m[i,j]=Math.Min(m[i,j],m[i,k]+m[k+1,j]+arr[i-1]*arr[k]*arr[j]);
            }

        Console.WriteLine(m[1,n-1]);
    }
}