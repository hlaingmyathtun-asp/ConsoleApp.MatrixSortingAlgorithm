using System;

namespace QuadraticTimeO_n_c
{

	class Program
	{
        static void Main(string[] args)
        {

            int n = 10;
            int c = 2; // increment value
            //first Loop
            for (int i = 1; i <= n; i+=c)
            {
                for (int j = 1; j <= n; j+=c)
                {
                    Console.Write("Expression at ");
                    Console.Write(" ( ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i);
                    Console.ResetColor();
                    Console.Write(" , ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(j);
                    Console.ResetColor();
                    Console.Write( " ) ");
                    Console.WriteLine();
                }
            }
            //second Loop
            Console.WriteLine();
            for (int i = n; i > 0; i -= c)
            {
                for (int j = i+1; j <= n; j+=c)
                {
                    Console.Write("Expression at ");
                    Console.Write(" ( ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(i);
                    Console.ResetColor();
                    Console.Write(" , ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(j);
                    Console.ResetColor();
                    Console.Write(" ) ");
                    Console.WriteLine();
                }
            }
            //third loop
            Console.WriteLine();

            for (int i = n;  i > 0; i -= c)
            {
                for(int j = i-1;  j > 0; j -=c)
                {
                    Console.Write("Expression at ");
                    Console.Write(" ( ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(i);
                    Console.ResetColor();
                    Console.Write(" , ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(j);
                    Console.ResetColor();
                    Console.Write(" ) ");
                    Console.WriteLine();
                }    
            }
                
        }
    }



}