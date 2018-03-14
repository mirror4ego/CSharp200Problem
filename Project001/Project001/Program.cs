using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Jungbo.Basic
{
    /// <summary>
    /// 두 수를 입력받는다. 두 수를 각각 int로 변환한다.
    /// 두 수를 합하여 결과를 출력한다.
    /// </summary>
    /// <param name="args"></param>
    class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("덧셈을 하려고 합니다. 두 수를 입력하세요.");

            Console.Write("첫 번째 수를 입력하세요:     ");
            int num1 = int.Parse(Console.ReadLine());// 첫 번째 수 입력 후 변환

            Console.Write("두 번째 수를 입력하세요:     ");
            int num2 = int.Parse(Console.ReadLine());// 두 번째 수 입력 후 변환

            // {0} 위치에 num1이, {1} 위치에 num2가 들어간다.
            Console.WriteLine("두 수의 합: {0}+{1}={2}", num1, num2, num1 + num2);
        }
    }
}
