using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
    internal class MergedSort
    {
        public void Divide( int[]Arr, int si, int ei)
        {
            // if si is grater or equal then retun the function:
            if(si>=ei)
            {
                return;
            }
            int mid =si+(ei-si)/2;
            Divide(Arr,si,mid);
            Divide(Arr, mid + 1, ei);
            Conquer(Arr,si,mid, ei);

        }

        public void Conquer(int[]Arr, int si,int mid, int ei)
        {
            int[] merge = new int[ei - si + 1];
            int idx1 = si;
            int idx2 = mid+1;
            int x = 0;
            while(idx1 <= mid&& idx2<=ei) {
                if (Arr[idx1] <= Arr[idx2])
                {
                    merge[x++] = Arr[idx1++];
                }
                else
                    merge[x++] = Arr[idx2++];
            }
            while(idx1 <= mid)
            {
                merge[x++] = Arr[idx1++];
            }
            while (idx2 <= ei)
            {
                merge[x++] = Arr[idx2++];
            }
            for (int i = 0, j = si; i < merge.Length; i++, j++)
            {
                Arr[j] = merge[i];
            }
        }
    }
}
