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
        // binary serch using Ittration:
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

        // Binary serch Using Recursion:

        public int BinaryRSearch(int[]A,int value,int l,int r)
        {
            if (l > r)
                return -1;

            else
            {
                int m= (l+r)/2;
                if (A[m] == value)
                {
                    return m;
                }
                else if (A[m] > value)
                    return BinaryRSearch(A, value,l, r - 1);
                else if (A[m] < value)
                    return BinaryRSearch(A, value,l + 1, r);

            }

            return -1;

        }
    }
}
