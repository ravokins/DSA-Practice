using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lern_Practice
{  
    internal class ProblemR
    {
        // Calculating sum of n natural number:
        // Using Formaula
        public int Sumn(int n)
        {
            return n * (n + 1) / 2;
        }
        // Using Noramal Itration:
        public int SumnIteraton(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i++;
            }
            return total;
        }
        //Using Recursion:
        public int SumnRecursion(int n)
        {
            if(n == 0)
                return 0;
            return SumnRecursion(n - 1)+n;
        }
    }
}
