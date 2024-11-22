namespace SortingSummarize_Bub_Sel_Inser_Matr;

class MatrixRowColumnInsSorting
{

    public static int[,] MatrixRInsSorting(int[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                int key = matrix[i,j];
                int k = j - 1;

                while ( k>= 0 && matrix[i,k] < key)
                {
                    matrix[i, k + 1] = matrix[i, k];
                    k = k - 1;
                }

                matrix[i, k + 1] = key;
                

            }

        }

        return matrix;
        
    }


    public static int[,] MatrixCInsSorting(int[,] matrix)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
       
            for (int i = 1;  i < matrix.GetLength(0); i++)
            {
                int key = matrix[i, j];

                int k = i - 1;

                while (k >= 0  && matrix[k,j] < key)
                {

                    matrix[k + 1, j] = matrix[k, j];


                    k = k - 1;
                }
                matrix[k + 1, j] = key;


            }

        }


        return matrix;
    }

}
