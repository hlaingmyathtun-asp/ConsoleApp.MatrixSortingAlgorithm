namespace LinearSearch
{
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            int[] arr = { 10, 50, 30, 70, 80, 20, 90, 40 };
            int target = 44;
           
            bool result = LinearSearch(arr, target);
            DisplayResult(result, target, arr);

            int[,] arr1 = { { 10, 20, 30, 40 }, { 41, 20, 10, 30 }, { 20, 41, 42, 44 } };

            bool result1 = MatrixLinearSearch(arr1, target, out int indexI,out int indexJ); // to take the index location with out parameter

            MatrixDisplayResult(result1, target, arr1, indexI, indexJ);



          
           
            
          
        }


        public static void MatrixDisplayResult(bool result, int target, int[,] arr, int indexI, int indexJ)
        {
            if (result)
            {
                Console.WriteLine($"target no: [{target}] was found in at index [{indexI},{indexJ}] ");
               
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write(" | ");
                   
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                      
                        Console.Write(arr[i,j]);

                        if (arr[i, (arr.GetLength(1) - 1)] != arr[i, j])
                        {
                            Console.Write(" , ");

                        }
                    }
                    Console.Write(" | ");

                    Console.WriteLine();
                }
               
                Console.WriteLine();

            }

            else
            {
                Console.WriteLine($"target no: {target} wasn't find");
            }

        }

        public static void DisplayResult(bool result, int target, int[] arr)
        {
           
            
            if (result)
            {
                Console.Write($"target no: [{target}] was found in ");
                Console.Write(" { ");
                foreach (int i in arr)
                {
                    Console.Write(i);
                    if (arr[arr.Length - 1] != i)
                    {
                        Console.Write(" , ");
                    }

                }
                Console.Write(" } ");
                Console.WriteLine();

            }

            else
            {
                Console.WriteLine($"target no: {target} wasn't find");
            }


        }


        public static bool LinearSearch(int[] arr, int target)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == target)
                {
                   
                    
                    return true;
                }

            }

            return false;

           
        }



        public static bool MatrixLinearSearch(int[,] arr, int target, out int indexI, out int indexJ)
        {
            indexI = 0;
            indexJ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == target)
                    {
                        indexI = i;
                        indexJ = j;
                        return true;
                    }
                      
                    

                }

            }

           
            return false;

            
           
        }
    }

    
}
