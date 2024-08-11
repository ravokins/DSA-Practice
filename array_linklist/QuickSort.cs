using System;

namespace DSA_Lern_Practice
{
    internal class QuickSort
    {
        public void QuickSorting(int[]Arr,int low, int high)
        {
          if(low < high)
          {
                int pindx = Partitioner(Arr, low, high);
                // for small -left
                QuickSorting(Arr,low, pindx-1);
                //for  high - right
                QuickSorting(Arr,pindx+1, high);
          }

        }
        public int Partitioner(int[]Arr,int low, int high)
        {
            int pivot = Arr[high]; // Define pivot:
            int i = low - 1;//Extra space for element swap:
            for(int j = low; j < high; j++) {
                if (Arr[j] < pivot)
                {
                    i++;
                    int temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                }
            }
            //swap pivot for higher element:
            i++;
            int temp1 = Arr[i];
            Arr[i] = Arr[high];
            Arr[high] = temp1;
            return i;
        }
    }
}
