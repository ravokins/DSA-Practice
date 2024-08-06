using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
     class QuestionSorting
    {
        public static void SlectionSort(int[]arr)
        {
            int n= arr.Length;
            for( int i = 0; i<n;i++)
            {
                int min = i;

                for(int j = i+1; j < n  ; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;

                }
                // swap the min number found in whole array with index 1:
                if (min!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                } 
            }
            

        }

        /*public static void InsertionSort(int[]arr)
        {
            int n= arr.Length;
            for(int i = 0; i<n-1; i++)
            {
                int comp = arr[i];
                int j = i - 1;

               ) { }
            }
        }*/

        public static void Print(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr= { 10,233,44,89,0,1 };
            Console.WriteLine("Before Sorting:");
            Print(arr);
            Console.WriteLine("\nAfter Sorting:");
            SlectionSort(arr);
            Print(arr);
        }
    }
}
