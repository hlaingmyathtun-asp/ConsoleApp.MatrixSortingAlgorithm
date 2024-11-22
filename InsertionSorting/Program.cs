using System;
using System.Collections.Generic;

namespace InsertionSorting;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 23, 1, 10, 5, 2, 7, 9 };

        int[] newArray = InsertionSort(arr);

     

        Console.WriteLine();
        foreach (int item in newArray)
        {
            Console.Write("Expression at ");
            Console.Write(" ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(item);
            Console.ResetColor();
            //Console.Write(" , ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(j);
            //Console.ResetColor();
            Console.Write(" ) ");
            Console.WriteLine();
        }

    }

    /// <summary>
    /// Time Complexity of Insertion Sort
///    Best case: O(n) , If the list is already sorted, where n is the number of elements in the list.
///    Average case: O(n 2 ) , If the list is randomly ordered
///Worst case: O(n 2 ) , If the list is in reverse order
///Space Complexity of Insertion Sort
///Auxiliary Space: O(1), Insertion sort requires O(1) additional space, making it a space-efficient sorting algorithm
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for(int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }

        return arr;
    }
}