
using System.Runtime.ExceptionServices;

namespace AnalysisOFAlgorithm
{

    public delegate decimal Factorial(object n);
    public delegate void FactorialNLoop(object n);
    internal class Program
    {
        static void Main(string[] args)
        {
            // threading technique is more faster than task 
            // currently cannot use together bother thread and task
            // analyis of algorithm
            //factorial number can count until 27  for decimal
            decimal number = 10; // change the value to see the time difference
            Console.WriteLine(decimal.MaxValue);
           

            Thread t1 = new Thread(new ParameterizedThreadStart(SumOfNumber));
          

            Thread t2 = new Thread(new ParameterizedThreadStart(Sum1OfNumber));
          

            Thread t3 = new Thread(new ParameterizedThreadStart(Sum2OfNumber));

            
            t1.Start(number);
            t2.Start(number);
            t3.Start(number);

            Task ta1 = new Task(delegate (object? number)
            {
                decimal sum = 0;
                for (decimal i = Convert.ToDecimal(number?.ToString()); i > 0; i--)
                {
                    sum += i;
                }

                Console.WriteLine("N time method using Task: {0} ", sum);
            }, number

            
            );


            Task ta2 = new Task(delegate (object? n)
            {
                decimal number1 = Convert.ToDecimal(n?.ToString());

                decimal result = number1 * ((number1 + 1)) / 2;
                Console.WriteLine("constanct time method using Task : " + result);

            }, number);

            Task ta3 = new Task(delegate (object? n)
            {
                decimal sum = 0;
                for (decimal i = 0; i < Convert.ToDecimal(n?.ToString()); i++)
                {
                    for (decimal j = 0; j <= i; j++)
                    {
                        sum += 1;
                    }
                }

                Console.WriteLine("N2 time method using task:  " + sum);
            }, number);


            ta1.Start();
            ta2.Start();
            ta3.Start();

            //Task f1 = new Task(delegate (object? n)
            //{

            //}, number);

            Factorial f1 = new Factorial(FactorialNumberRecursive);
            //f1(number);
            Console.WriteLine("Recursive factorial number: " + f1(number));
            FactorialNLoop f2 = new FactorialNLoop(FactorialNumberNloop);
            f2(number);
            
            FibonanciSequence(number); // decmial value unitl to 139
        }


        public static void FibonanciSequence(object number)
        {
            decimal third = 0;
            decimal firstNumber = 0;
            decimal secondNumber = 1;
            decimal i = 1;
            Console.Write($"{number}th is:  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[ ");
            Console.Write($"{firstNumber} , {secondNumber} , ");
            while (i != Convert.ToInt32(number.ToString()))
            {

                

                third = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = third;
                i++;
               
                Console.Write($"{third}");
                 if (i!= Convert.ToInt32(number.ToString()))
                {
                    Console.Write(" ,  ");
                }
                 else if( i == Convert.ToInt32(number.ToString()))
                {
                    Console.Write(" ]  ");
                    Console.ResetColor();
                }
            }




            Console.WriteLine();
            Console.WriteLine($"{number}th is: {third} at index {i+1}");

            Console.WriteLine();

        }

        public static decimal FactorialNumberRecursive(object n)
        {
          
            decimal no = Convert.ToDecimal(n.ToString());

            if (no == 1)
                return 1;

            return FactorialNumberRecursive(no - 1) * no;

        }

        public static void FactorialNumberNloop(object n)
        {
            decimal no = Convert.ToDecimal(n.ToString());
            decimal product = 1;
            for(decimal i = no; i > 0; i --)
            {
                product *= i;
            }

            Console.WriteLine("FactorailNumberNLoop : " + product);
        }



        public static void SumOfNumber(object? n)
        {
            decimal sum = 0;
            for (decimal i = Convert.ToDecimal(n.ToString());  i > 0; i--)
            {
                sum += i;
            }

            Console.WriteLine("N time method: {0}", sum);

        }


        public static void Sum1OfNumber(object? n)
        {
            decimal number = Convert.ToDecimal(n.ToString());
            
            decimal result =  number * ((number + 1)) / 2;
            Console.WriteLine("constanct time method : " + result);
           

        }


        public static void Sum2OfNumber(object? n)
        {
            decimal sum = 0;
            for (decimal i = 0; i < Convert.ToDecimal(n.ToString()); i++)
            {
                for (decimal j = 0; j <= i; j++)
                {
                    sum += 1;
                }
            }

            Console.WriteLine("N2 time method : " + sum);

        }
    }
}
