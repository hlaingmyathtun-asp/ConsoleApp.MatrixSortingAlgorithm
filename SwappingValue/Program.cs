using System;

namespace SwappingValue
{
	class Program
	{
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Before Swapping");
            Console.WriteLine("  a = " + a);
            Console.WriteLine("  b = " + b);

            a.Swapping(ref b);

            Console.WriteLine( "After swapping");
            Console.WriteLine("  a = " + a);
            Console.WriteLine("  b = " + b);

            a = 30;
            b = 40;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("  a = " + a);
            Console.WriteLine("  b = " + b);
            //a.Swapping(ref b);
            Console.WriteLine("After using array swapping");
         
            foreach (int i in a.Swapping(ref b))
            {
                if (i == a)
                {
                    Console.WriteLine("a = " + a);
                }
                else if ( i == b)
                {
                    Console.WriteLine("b = " + b);
                }
            }

           

            string firstString = "Hlaing";
            string secondString = "Myat";

            Console.WriteLine("Before swapping");
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine();

            Console.WriteLine("After swapping");

            MyCustomExtension.Swapping(ref firstString, ref secondString);

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);

            int result = 2 ^ 1;
            Console.WriteLine("2 square is  {0}" , result);

           

            

        }


        
    }

    static class MyCustomExtension
    {

        /// <summary>
        /// must be passed the ref keyword
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] Swapping(this ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            int[] newValue = new int[] { a, b };
            return newValue;
        }

       
        /// <summary>
        /// must be passed the ref keyword
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>

        public static string[] Swapping( ref string firstString , ref string  secondString)
        {
            string temp;
            temp = firstString;
            firstString = secondString;
            secondString = temp;
            string[] newString = new string[] { firstString, secondString };

            return newString;
        }

    }
}