using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 삼항 연산자
/// 문제 내용 : 입력된 정수가 짝수인지 홀수인지 알아보자
/// 학습 내용 : 삼항 연산자를 익힌다.
/// 힌트 내용 : 삼항 연산자(C ? A : B)는 C의 조건식이 참이면 A를, 거짓이면 B를 리턴한다.
/// </summary>

namespace Project012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("짝수/홀수를 판별합니다.");

            Console.Write("정수를 하나 입력하세요: ");
            int iNum = int.Parse(Console.ReadLine());

            bool isE = Numbers.IsOdd(iNum);
            if(isE)
            {
                Console.WriteLine("{0}은/는 홀수입니다.", iNum);
            }
            else
            {
                Console.WriteLine("{0}은/는 짝수입니다.", iNum);
            }
        }
    }

    public class Numbers
    {
        public static bool IsEven(int num)
        {
            bool isP = (num % 2 == 0) ? true : false;
            return isP;
        }

        public static bool IsOdd(int num)
        {
            return (num % 2 == 1) ? true : false;
        }
    }
}
