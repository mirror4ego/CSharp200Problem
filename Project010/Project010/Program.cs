using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 예약어와 이름 명령법 
/// 예약어는 모두 소문자로써 프로그램에서 이미 정의되어 사용되고 있는 것으로 사용자가 변수나 클래스, 메서드의 이름으로 선언하여 사용할 수 없다.
/// 식별자 규칙
///     일반문자 : 모두 사용가능
///     _ : 모두 사용가능
///     @ : 가장 왼쪽에만 한 번 사용
///     특수문자(@제외) : 모든 곳에서 사용 불가
///     숫자 : 사용 가능하나 숫자로 시작할 수는 없다
/// 
/// 파스칼 : 왼쪽 첫 자는 대문자, 의미있는 부분은 대문자, 그 외에는 소문자
///         클래스, 인터페이스, 생성자, 추상 클래스, 메서드, 네임스페이스
/// 카멜 : 왼쪽 첫 자는 소문자, 의미있는 부분은 대문자, 그 외에는 소문자
///         멤버 필드,  WInForm 위젯
/// 헝가리안 : 줄여서사용( 권장하지 않음)
///         WinForm 위젯
/// 전체 대문자 : const와 같이 사용해서 변수명을 대문자로 지정한다
///         상수
/// 전체 소문자 : 예약어로써 변수, 클래스, 메서드 등의 이름으로 사용 불가함
///         예약어(키워드)
/// 
/// 
/// 예외적으로 참조 타입(클래스)은 파스칼 명령법을 사용해야 하나 String은 string, Object를 object로 사용한다.
/// </summary>
namespace Project010
{
    class Program
    {
        static void Main(string[] args)
        {
        


        }
    }
}
