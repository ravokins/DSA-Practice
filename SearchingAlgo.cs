using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
    internal class SearchingAlgo
    {
        public int LinearSearch(int[]A,int n,int value)
        {
            int index = 0;
             while(index < n)
            {
                if (A[index] ==value) 
                {
                    return index;  
                }
                index++;

            }
            return -1;
        }
    }
}
