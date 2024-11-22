namespace SortingSummarize_Bub_Sel_Inser_Matr;

class MatrixRowColumnBSort
{

    public static int[,] MatrixRBubbSorting(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i,j] < matrix[i,k])
                    {
                        int temp = matrix[i, j];
                        matrix[i,j] = matrix[i,k];
                        matrix[i,k] = temp;
                    }
                }

            }
        }

        return matrix;

    }


    public static int[,] MatrixCBubbSorting(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[i,j] > matrix[k,j])
                    {
                        int temp = matrix[i, j];
                        matrix[i,j] = matrix[k,j];
                        matrix[k,j] = temp;
                    }
            }
            }

        }

        return matrix;
    }

    

}
