using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
    internal class InsertionSort
    {
        public void InsertionSorting(int[] Arr)
        {
            // 3| 4 5 6 1 9 0
            int n = Arr.Length;
            int key, j,i;

            // This will do number of passes:
            for (i = 1; i < n; i++)
            {
                key = Arr[i];
                j = i - 1;

                // this will go through each sorted element and compare it 
                while (j >= 0 && Arr[j] > key)
                {
                    Arr[j + 1] = Arr[j];
                    // J-- because we have to check in previous sorted arrary
                    j--;
                }
                // If the key A[i] is not smaller than arr[j] then do this:
                Arr[j + 1] = key;
            }

        }
    }
}
