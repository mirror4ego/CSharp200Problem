using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1차원 배열(버블 정렬)
/// 문제 내용 : 6,3,8,9,2,1,4,7,5를 크기순으로 정렬하자.
/// 학습 내용 : 1차원 배열을 버블 정렬로 정렬한다.
/// 힌트 내용 : 배열이란 같은 타입의 나열(묶음)이다. 버블 정렬의 기본은 가장 큰 수를 가장 오른쪽으로 보내는 것이다.
/// </summary>

namespace Project030
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mm = { 6, 3, 8, 9, 2, 1, 4, 7, 5 };
            Console.WriteLine("정렬전----------");
            Bubble.Print(mm);
            Console.WriteLine("정렬후----------");
            Bubble.AscSort(mm);
            Bubble.Print(mm);
        }
    }
}
