using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace BubbleSorting
{
	class Program
	{
        static void Main(string[] args)
        {

            int[] arr = { 2, 5, 3, 10, 1, 8, 20, 30 };
            int[] newArray1 = BubbleSorting(arr);

            foreach (int item in newArray1)
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



        public static int[] BubbleSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }


     



        
    }


  

}