namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //binary search does not suitable in matrix
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6,7,8,9,10,11,12,13,14,15,16,17,18,19,29,40,60,70,80,90,100,110,120,130,140,150,160 };

            int target = 160;

            bool result = BinarySearch(arr, target, out int index);

            DisplayResult(result, target, arr, index);


            int[,] arr1 = { { 1, 2, 3, 4 }, { 5,6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 29 }, { 40, 60, 70, 80 }, { 90, 100, 110, 120}, { 130, 140, 150, 160 } };



            bool result1 = MatrixBinarySearch(arr1, target, out int indexI, out int indexJ);

            MatrixDisplayResult(result1, target,arr1,indexI, indexJ);



            

        }



       


        public static void DisplayResult(bool result, int target, int[] arr,int index)
        {
            if (result)
            {
                Console.Write($"target no: [{target}] was found at index [{index}] in ");
                Console.WriteLine();
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
            Console.WriteLine();

        }


        public static bool BinarySearch(int[] arr, int target, out int index)
        {
            index = 0;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if (arr[mid] == target)
                {
                    index = mid;
                    return true;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
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

                        Console.Write(arr[i, j]);

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



        public static bool MatrixBinarySearch(int[,] arr, int target, out int indexI, out int indexJ)
        {
            indexI = 0;
            indexJ = 0;
            int rleft = 0;
            int cleft = 0;
            int cright = arr.GetLength(1) -1 ;
            int right = arr.GetLength(0) -1;



            //used the linear search
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {


            //        if (arr[i, j] == target)
            //        {
            //            indexI = i;
            //            indexJ = j;
            //            return true;
            //        }



            //    }
            //}
            //still need to improve the logic 

            while (cleft <= cright)
            {



                int midr = rleft + (right - rleft) / 2;

                int midc = cleft + (cright - cleft) / 2;



                if (arr[midr, midc] == target)
                {
                    indexI = midr;
                    indexJ = midc;
                    return true;
                }
                else if (arr[midr, midc] < target)
                {
                    cleft = midc + 1;
                    rleft = midr + 1;
                }

                else
                {
                    right = midr - 1;
                    cright = midc - 1;
                }

            }



            return false;
            }
        }
    
}
