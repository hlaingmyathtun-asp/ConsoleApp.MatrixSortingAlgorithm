using System;
using System.Collections.Concurrent;
using System.Numerics;

namespace SortingSummarize_Bub_Sel_Inser_Matr;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, 1, 10, 20, 9, 7, 8, 2, 15, 11, 17, 12, 23, 40, 50 };

        Console.WriteLine("Befor sorting: ");
        SortingDisplay(arr);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");

        BSorting.BubbleSorting(arr);
        Console.WriteLine("After using the bubble Sorting: ");
        SortingDisplay(arr);

        SelSorting.SelectSorting(arr);
        Console.WriteLine("After using the selecting sorting: ");
        SortingDisplay(arr);

        ISorting.InsertedSorting(arr);

        Console.WriteLine("After using the inserted sorting");
        SortingDisplay(arr);

        Console.WriteLine("-----------------------------" );
        Console.WriteLine();
        int[,] matrix = { { 3, 7, 1, 2, 5 }, { 4, 2, 1, 8, 9 }, { 10, 9, 5, 6, 8 }, { 11, 10, 9, 4, 5 }, { 20, 10, 15, 12, 11 } };

        MatrixDisplay(matrix);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("After using row sorting matrix with bubble sorting technique ");
        MatrixRowColumnBSort.MatrixRBubbSorting(matrix);
        MatrixDisplay(matrix);
        Console.WriteLine();
        Console.WriteLine("After using column sorting matrix with bubble sorting technique ");
        MatrixRowColumnBSort.MatrixCBubbSorting(matrix);
        MatrixDisplay(matrix);

        Console.WriteLine("After using row sorting matrix with selection sorting technique");
        MatrixRowColumnSelSorting.MatrixRSelSorting(matrix);
        MatrixDisplay(matrix);
        Console.WriteLine();

        Console.WriteLine("After using column sorting matrix with selection sorting technique");
        MatrixRowColumnSelSorting.MatrixCSelSorting(matrix);
        MatrixDisplay(matrix);
        Console.WriteLine();


        Console.WriteLine("After using row sorting matrix with insertion sorting technique");
        MatrixRowColumnInsSorting.MatrixRInsSorting(matrix);
        MatrixDisplay(matrix);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");


        Console.WriteLine("After using column sorting matrix with insertion sorting technique");
        MatrixRowColumnInsSorting.MatrixCInsSorting(matrix);
        MatrixDisplay(matrix);
        Console.WriteLine();


    }


    public static void SortingDisplay(int[] arr)
    {
        Console.Write(" { ");
        foreach (int i in arr)
        {
            if (i != 0)
            {
                Console.Write($"{i}");
                if (i != arr[^1])
                    Console.Write(" , ");

            }

        }
        Console.Write(" } ");
        Console.WriteLine();
    }



    public static void MatrixDisplay(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();

        }
    }
}
