


using System;

namespace algor_wk_5
{
    class Program
    {

        static void bubbleSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            int[] myArray_1 = { 123, 34, 189, 56, 150, 12, 9, 240 };
            bubbleSort(myArray_1, 8);
            for (int i = 0; i < (myArray_1.Length); i++)
            {
                Console.WriteLine(myArray_1[i]);
            }
            
            
            
            
        }
    }
}
