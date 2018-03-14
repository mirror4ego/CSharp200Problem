using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project104
{
    class Recursion
    {
        public static int GCD(int m, int n)
        {
            if (n == m)
            {
                return m;
            }
            else
            {
                if (m > n)
                {
                    return GCD(m - n, n);
                }
                else
                {
                    return GCD(m, n - m);
                }
            }

        }
        public static int LCM(int m, int n)
        {
            return (m * n) / GCD(m, n);
        }
    }
}
