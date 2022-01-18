using System;

namespace algorithms.sorting
{
    internal class Bubble
    {
        public static int[] BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 2; i++)
            {
                for( int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        /* Prints the array */
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver method
        public static void Main()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }
    }
}
