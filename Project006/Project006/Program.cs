using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int iNum1 = 3;      // 정수 대입
            int iNum2 = 5;
            const int INUM = 6; // 새로운 대입 불가
           

            double dNum1 = 3.0; // 실수 대입
            double dNum2 = 8.0;
            dNum1 = 4.0;        // 새로운 대입

            int iNum3 = iNum1 + iNum2;      // 정수 덧셈
            double dNum3 = dNum1 - dNum2;   // 실수 뺄셈

            Console.WriteLine("{0}+{1}={2}", iNum1, iNum2, iNum3);
            Console.WriteLine("{0}-{1}={2}", dNum1, dNum2, dNum3);
            Console.WriteLine("상수 {0}", INUM);
        }
    }
}
