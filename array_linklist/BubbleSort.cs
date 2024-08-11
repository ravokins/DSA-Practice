using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{
    internal class BubbleSort
    {
        public void PrintArray(int[] Arr)
        {
            foreach (int i in Arr)
            {
                Console.Write(" "+i+" ");
            }
        }

        public void BubbleSorting(int[] Arr)
        {
            bool Swaping=false;
            int n= Arr.Length;
            // This will itrate over multiple phase lets say for first phase it will sort last one element similerly for second phase it will sort second last element and so on:
            for(int i = 0; i < n; i++)
            {   
                Swaping = false;
                //This will go through each index of the array element and check and according to that it will move the element from left to right:
                for(int j = 1; j < n - i; j++)
                { 
                    // it will check if A[j] <A[j-1] i.e = i(because when a[j] is at first indext but arry [j-1] at previous index where i is alreday present:)
                    if(Arr[j] < Arr[j - 1])
                    {
                        // This will perform swaping by storing one index value in temp and replacing with other:
                        int temp;
                        temp = Arr[j];
                        Arr[j]=Arr[j-1];
                        Arr[j - 1] = temp;
                        Swaping = true;
                    }
                }
            }
            // if arrary is already sorted just return the function don't perform any itration:
            if (Swaping==false)
                return;

        }
    }
}
