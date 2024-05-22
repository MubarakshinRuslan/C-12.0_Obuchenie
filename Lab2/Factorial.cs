using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Factorial
    {
        public static long Ffactorial(int n)
        {
            long res = 1;
            for(int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        public static long Rfactorial(int n) => n < 1 ? 1 : n * Rfactorial(n - 1);
    }
}
