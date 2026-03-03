using System;

class BinarySearch
{
    static int Search(int[] arr, int left, int right, int key)
    {
        if (right >= left)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == key) return mid;
            if (arr[mid] > key) return Search(arr, left, mid - 1, key);
            return Search(arr, mid + 1, right, key);
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int result = Search(arr, 0, arr.Length - 1, 10);
        Console.WriteLine(result);
    }
}