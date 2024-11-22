using System;
using System.Diagnostics;


namespace LogarithmicTimeComplexityO_LogN;

class Program
{

    static void Main(string[] args)
    {
        int n = 10;
        int c = 2;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 1; i <= n; i *= c)
        {
            Console.Write("Expression at i ");
            Console.Write(" ( ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i);
            Console.ResetColor();
            Console.Write(" ) ");
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = n; i>0; i /= c)
        {
            Console.Write("Expression at i ");
            Console.Write(" ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(i);
            Console.ResetColor();
            Console.Write(" ) ");
            Console.WriteLine();
        }
        sw.Stop();

        Console.WriteLine(sw.Elapsed.TotalMilliseconds);
    }
   
}