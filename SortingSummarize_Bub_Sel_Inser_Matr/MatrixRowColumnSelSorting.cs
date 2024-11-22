namespace SortingSummarize_Bub_Sel_Inser_Matr;

class MatrixRowColumnSelSorting
{


    public static int[,] MatrixRSelSorting(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sel = j;

                for (int k = j; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i,sel] > matrix[i,k])
                    {
                        sel = k;
                    }

                }

                int temp = matrix[i,sel];
                matrix[i, sel] = matrix[i, j];
                matrix[i,j]=temp;
            }

        }

        return matrix;
    }



    public static int[,] MatrixCSelSorting(int[,] matrix)
    {
       for(int i = 0;i < matrix.GetLength(0); i++)
        {
            int sel = i;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               
                 for (int k = i; k < matrix.GetLength(0); k++)
            {
                if (matrix[sel, j] > matrix[k, j])
                {
                    sel = k;
                }
            }
            int temp = matrix[sel, j];
            matrix[sel, j] = matrix[i, j];
            matrix[i, j] = temp;

            }

         

        }

        return matrix;
    }

}