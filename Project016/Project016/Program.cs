using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Math 클래스
///  문제내용 : 수학 메서드를 사용하여 다이아몬드를 만들자.
///  학습 내용 : 절대값을 이용하는 방법을 익힌다. 바깥쪽 for 문과 안쪽 for 문의 관계식을 유도한다.
///  힌트 내용 : 규칙적으로 증가하다가 감소하거나, 감소하다가 증가하면 절대값을 이용한다.
/// </summary>

namespace Project016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("다이아몬드를 출력합니다.");
            Console.Write("홀수인 정수 하나를 입력하세요: ");
            int iNum = int.Parse(Console.ReadLine());

            Asterisk.ShowDiamond(iNum);
            Console.WriteLine();
            Asterisk.ShowReverseDiamond(iNum);
        }
    }

    public class Asterisk
    {
        public static void ShowDiamond(int n)
        {
            for(int i = 0; i<n; i++)
            {
                for (int j=0; j<Math.Abs(i-n/2); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < n-2*Math.Abs(i - n / 2); k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        public static void ShowReverseDiamond(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < Math.Abs(i - n / 2); j++)
                {
                    Console.Write("X");
                }
                for (int k = 0; k < n - 2 * Math.Abs(i - n / 2); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < Math.Abs(i - n / 2); j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
