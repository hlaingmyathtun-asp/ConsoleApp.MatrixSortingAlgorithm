using System;

namespace SelectionSorting;

class MyClass
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 12, 25, 22, 11 };

        int[] newArray = SelectionSorting(arr);

        foreach (int item in newArray)
        {
            Console.Write("Expression at ");
            Console.Write(" ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(item);
            Console.ResetColor();
            //Console.Write(" , ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(j);
            //Console.ResetColor();
            Console.Write(" ) ");
            Console.WriteLine();
        }



    }

    /// <summary>
    /// Complexity Analysis of Selection Sort
///   Time Complexity: O(n2) ,as there are two nested loops:
///One loop to select an element of Array one by one = O(n)
///Another loop to compare that element with every other Array element = O(n)
///Therefore overall complexity = O(n) * O(n) = O(n* n) = O(n2)
///Auxiliary Space: O(1) as the only extra memory used is for temporary variables.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>

    public static int[] SelectionSorting(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int selected_item = i;
            for (int j = i+1; j < n; j++)
            {
                if (arr[selected_item] > arr[j])
                {
                    selected_item = j;
                }

            }

            int temp = arr[i];
            arr[i] = arr[selected_item];
            arr[selected_item]= temp;

        }

        return arr;
    }

}