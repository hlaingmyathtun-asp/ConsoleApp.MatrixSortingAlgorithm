using System;
using static System.Net.Mime.MediaTypeNames;

namespace MatrixTraversal;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix ={ { 0, 6, 8, 9, 11 },
            { 20, 22, 28, 29, 31 },
            { 36, 38, 50, 61, 63 },
            { 64, 66, 100, 122, 128 }
        };
        Console.WriteLine("Displaying the matrix ");
        MatrixDisplay(matrix);
        Console.WriteLine("Searching the value");
        MartixSearch(matrix, 100);

        
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


    public static void MartixSearch(int[,] matrix, int targetValue)
    {
        bool found = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == targetValue)
                {
                    found = true;
                    Console.Write($" {targetValue}, Found in ({i+1}, {j+1})");
                }
                
            }
            
        }

        if (found != true)
        {
            Console.Write($"{targetValue}, wasn't find");
        }


    }



    
}