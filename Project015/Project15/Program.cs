using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 등차수열
/// 문제 내용 : 'X'와 공백(' ')을 이용하여 피라미드 계단을 만들자
/// 학습 내용 : 등차수열을 이용하여 for 조건식을 만든다.
/// 힌트 내용 : 1, 3, 5, 7, 9는 뒤쪽 수를 앞쪽 수로 빼면 2를 얻는다. 2를 공차라고 하며, 이런 수열을 등차수열이라고 한다.
/// </summary>

namespace Project15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("만들 피라미드 계단이 높이를 정수로 입력 : ");
            int height = int.Parse(Console.ReadLine());

            MakeStair makeStair = new MakeStair();
            makeStair.ShowStageTree(height);
            Console.WriteLine();
            makeStair.ShowStageV(height);


        }
    }

    public class MakeStair
    {
        public void ShowStageTree(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < num - i - 1; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        public void ShowStageV(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < num - i - 1; k++)
                {
                    Console.Write("X");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < num - i - 1; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
