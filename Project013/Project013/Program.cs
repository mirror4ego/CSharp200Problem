using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 순환문 for
/// 문제 내용 : 입력된 정수만큼 X를 출력하자.
/// 학습 내용 : for 순환문 사용법을 익힌다.
/// 힌트 내용 : for 순환문은 초기, 조건, 증감 스텝으로 구성된다.
/// </summary>

//namespace Project013
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("출력할 X의 갯수를 정수로 입력하세요");
//            int num = int.Parse(Console.ReadLine());

//            for(int i = 0; i < num; i++)
//            {
//                Console.Write("X ");
//            }

//            Console.WriteLine();
//        }
//    }
//}

namespace Project013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("출력할 X의 갯수를 정수로 입력하세요");
            int num = int.Parse(Console.ReadLine());

            Asterisk.ShowLine(num);
        }
    }

    public class Asterisk
    {
        public static void ShowLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("X ");
            }

            Console.WriteLine();
        }
    }
}
