using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
    internal class SlectionSort
    {
        public void SlectionSorting(int[] Arr)
        {
            int n=Arr.Length;
            
            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i+1; j < n; j++)
                {
                    
                    if (Arr[min] > Arr[j])
                    {
                        min = j;
                        
                       
                    }
                   
                }
                if(min!=i)
                {
                    int temp;
                    temp = Arr[i];
                    Arr[i] = Arr[min];
                    Arr[min] = temp;

                }
            }
        }
        
    }
}
