
namespace MatrixSortingRowRise

{



    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 77, 11, 22, 3 }, { 11, 89, 1, 12 }, { 32, 11, 56, 7 }, { 11, 22, 44, 33 } };

            //MatrixRollBSort(matrix);

            //MatrixRollSelSorting(matrix);

            MatrixRollInSorting(matrix);


        }

        /// <summary>
        /// matrix roll bubble sorting
        /// </summary>
        /// <param name="matrix"></param>
        public static void MatrixRollBSort(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }


                    }
                }

            }




            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    //Console.Write($" {i}, {j} <-- = {matrix[i, j]}");
                    Console.Write($"{matrix[i, j]}  ");


                }
                Console.WriteLine();
            }


        }




        public static void MatrixRollSelSorting(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int selected_item = j;

                    for (int k = j + 1; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, selected_item] > matrix[i, k])
                        {
                            selected_item = k;
                        }
                    }

                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, selected_item];
                    matrix[i, selected_item] = temp;

                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    //Console.Write($" {i}, {j} <-- = {matrix[i, j]}");
                    Console.Write($"{matrix[i, j]}  ");


                }
                Console.WriteLine();
            }


        }


        public static void MatrixRollInSorting(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)

                {
                    int key = matrix[i, j];
                    int k = j - 1;

                    while (k >= 0 && matrix[i, k] > key)
                    {
                        matrix[i, k + 1] = matrix[i, k];
                        k = k - 1;
                    }

                    matrix[i, k + 1] = key;

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    //Console.Write($" {i}, {j} <-- = {matrix[i, j]}");
                    Console.Write($"{matrix[i, j]}  ");


                }
                Console.WriteLine();
            }




        }







    }
}