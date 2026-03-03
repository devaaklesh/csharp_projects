using System;
using System.Collections.Generic;

class MinHeap
{
    static void Main()
    {
        List<int> heap = new List<int>();

        void Insert(int val)
        {
            heap.Add(val);
            int i = heap.Count - 1;

            while (i > 0 && heap[(i - 1) / 2] > heap[i])
            {
                (heap[i], heap[(i - 1) / 2]) = (heap[(i - 1) / 2], heap[i]);
                i = (i - 1) / 2;
            }
        }

        Insert(5);
        Insert(3);
        Insert(8);

        Console.WriteLine(heap[0]);
    }
}