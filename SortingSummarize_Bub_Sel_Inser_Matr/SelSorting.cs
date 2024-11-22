namespace SortingSummarize_Bub_Sel_Inser_Matr;

class SelSorting
{

    public static int[] SelectSorting(int[] arr)
    {
        int n = arr.Length;
       for(int i = 0; i < n; i ++)
        {
            int select_item = i;

            for (int j = i; j < n  ; j++) // if check all value from index of i and then compare step by step of index of j
            {
                if (arr[select_item] > arr[j]) // check the selected index
                {
                   select_item = j;
                   
                }

             
            }
            int temp = arr[select_item];
            arr[select_item] = arr[i];
            arr[i] = temp;




        }

      

        return arr;
    }

    
}
