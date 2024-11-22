namespace SortingSummarize_Bub_Sel_Inser_Matr;

class BSorting
{

    public static int[] BubbleSorting(int[] arr)
    {
        int n = arr.Length;
       for (int i = 0; i < n ; i++)
        {
            for (int j = 0; j < n ; j++) // it start to concern from index zero
            {
                if (arr[i] < arr[j]) // if i of index 0 is less than j of index 1
                {
                    int temp = arr[i]; // it move temp from i of index 0 
                    arr[i] = arr[j];// then now i of index 0 is free no more have value, then add the value of of j of index 0
                    arr[j] = temp; // put back the temp value to the j of index 0 to compare back with the other index of j
                }
            }
        }

       return arr;
    }




}
