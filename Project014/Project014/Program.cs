using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 중첩 for 문
/// 문제 내용 : 'X'와 공백(" ")을 이용하여 내려가는 계단과 올라가는 계단을 만들자.
/// 학습 내용 : for 안에 for가 있는 중첩 for 문의 활용법을 익힌다.
/// 힌트 내용 : 바깥 쪽 for의 스탭이 변경될 때마다 안쪽 for가 실행된다.
/// </summary>

namespace Project014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("만들 계단의 방향을 입력(0이면 올라가는 계단 1이면 내려가는 계단) : ");
            int direction = int.Parse(Console.ReadLine());
            Console.Write("만들 계단의 갯수를 입력 : ");
            int stairNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (direction==0)
            {
                for(int i = 0; i <= stairNum; i++)
                {
                    for (int j = 0; j < (stairNum - i); j++)
                    {
                        Console.Write(" ");
                    };
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("X");
                    };
                    Console.WriteLine("");
                };
            }
            else if(direction==1)
            {
                for (int i = 0; i <= stairNum; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("X");
                    };
                    for (int j = 0; j < (stairNum - i); j++)
                    {
                        Console.Write(" ");
                    };

                    Console.WriteLine("");
                };
            }
        }
    }
}
