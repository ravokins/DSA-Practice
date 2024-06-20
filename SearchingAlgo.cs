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

        public int BinarySearch(int[]A,int n,int value)
        {
            int l = 0;
            int r = n-1;
            while(l <= r)
            {
                int M = (l+r)/2;
                if (A[M] == value)
                {
                    return M;
                }
                else if (A[M] > value)
                {
                    r = M - 1;
                   
                }
                else if (A[M] < value)
                    l = M + 1;

            }

            return -1;
        }
    }
}
