using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///// <summary>
///// 조건문 if~else
///// 문제 내용 : 입력된 정수가 짝수인지 홀수인지 알아보자
///// 학습 내용 : if~else 조건문을 익힌다.
///// 힌트 내용 : 조건식 내용이 참이면 if의 바디를 실행하고 거짓이면 else의 바디를 실행한다
///// </summary>
//namespace Project011
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("홀수인지 짝수인지 확인할 정수를 입력하세요");
//            int iNum1 = int.Parse(Console.ReadLine());

//            if ((iNum1 % 2) == 1)
//            {
//                Console.WriteLine("입력값은 홀수입니다");
//            }
//            else
//            {
//                Console.WriteLine("입력값은 짝수입니다");
//            }

//        }
//    }
//}

namespace Project011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("짝수/홀수를 판별합니다.");
            Console.Write("한개의 정수를 입력하세요.");
            int iNum = int.Parse(Console.ReadLine());

            bool isE = Numbers.IsEven(iNum);
            
            if (isE)
            {
                Console.WriteLine("{0}은/는 짝수입니다", iNum);
            }
            else
            {
                Console.WriteLine("{0}은/는 홀수입니다", iNum);
            }

        }
    }

    public class Numbers
    {
        // 짝수인가?
        public static bool IsEven(int num)
        {
            bool isP = false;
            if (num % 2 == 0)
            {
                isP = true;
            }
            else
            {
                isP = false;
            }
            return isP;
        }

        public static bool IsOdd(int num)
        {
            bool isP = false;
            if (num % 2 != 0)
            {
                isP = true;
            }
            else
            {
                isP = false;
            }
            return isP;
        }
    }
}