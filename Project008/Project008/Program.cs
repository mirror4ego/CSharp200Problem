using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project008
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 29;
            int iNum2 = 9;

            int iNum3 = iNum1 + iNum2; // 29+9=38
            int iNum4 = iNum1 - iNum2; // 29-9=20
            int iNum5 = iNum1 * iNum2; // 29*9=261
            int iNum6 = iNum1 / iNum2; // 29/9=3.22222.... 이지만 정수형으로 저장하기 때문에 소수점 이하는 버려진다.
            int iNum7 = iNum1 % iNum2; // 29%9=2
            double iNum8 = iNum6;
            double iNum9 = iNum1 / iNum2;
            double iNum10 = (double) iNum1 / iNum2;

            Console.WriteLine("덧셈:{0}+{1}={2}", iNum1, iNum2, iNum3);
            Console.WriteLine("뺄셈:{0}+{1}={2}", iNum1, iNum2, iNum4);
            Console.WriteLine("곱셈:{0}+{1}={2}", iNum1, iNum2, iNum5);
            Console.WriteLine("나눗셈:{0}+{1}={2}", iNum1, iNum2, iNum6);
            Console.WriteLine("나머지:{0}+{1}={2}", iNum1, iNum2, iNum7);
            Console.WriteLine("정수형 변수에 있던 내용을 더블형으로 변환 : {0}, {1}, {2}", iNum8, iNum9, iNum10);


        }
    }
}
