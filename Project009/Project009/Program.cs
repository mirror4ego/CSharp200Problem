using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5칙연산입니다.");
            Console.WriteLine("숫자 연산자 숫자순");

            Console.WriteLine("첫 번째 수를 입력하세요(정수): ");
            int iNum1 = int.Parse(Console.ReadLine());

            Console.Write("+,-,*,/,% 중 원하는 연산자 입력: ");
            string opp = Console.ReadLine();

            Console.WriteLine("두 번째 수를 입력하세요(정수): ");
            int iNum2 = int.Parse(Console.ReadLine());

            // 개체 생성
            OperationCalculator oppCal = new OperationCalculator();

            // 메서드 호출
            int iNum3 = oppCal.Calculator(iNum1, iNum2, opp);
            Console.WriteLine("{0} {1} {2}={3}", iNum1, opp, iNum2, iNum3);
        }
    }
    // 클래스 선언
    public class OperationCalculator {
        // 메서드 선언
        public int Calculator(int x, int y, string opp) {
            int z = 0; // 5칙 연산 결과를 저장할 임시 변수
            // 원하는 5칙 연산을 선택
            switch (opp)
            {
                case "+": z = x + y; break;
                case "-": z = x - y; break;
                case "*": z = x * y; break;
                case "/": z = x / y; break;
                case "%": z = x % y; break;
            }
            return z; // 5칙연산에 알맞은 값을 리턴한다.
        }
    }
}
